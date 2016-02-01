﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFChatClient.ChatService;

namespace WCFChatClient
{
    public partial class ChatroomWomen : Form
    {
        CurrentUser _currentUser;
        int roomID = 3;
        public ChatroomWomen(CurrentUser user)
        {
            try
            {
                InitializeComponent();
                textBoxChat.Text = GlobalMethods.PopulateChatWithMessages(roomID, "Woman");
                _currentUser = user;
            }
            catch (FaultException ex)
            {
                GlobalMethods.ErrorMessages("Woman", "Service error", ex.Message, roomID, _currentUser.UserName);
                MessageBox.Show("Service error: " + ex.Message);
            }
            catch (Exception ex)
            {
                GlobalMethods.ErrorMessages("Woman", "Client error", ex.Message, roomID, _currentUser.UserName);
                MessageBox.Show("Client error: " + ex.Message);
            }
        }

        private void pictureBoxSend_Click(object sender, EventArgs e)
        {
            var message = textBoxMessage.Text;
            var userID = int.Parse(_currentUser.ID);
            try
            {
                if (message != null && message != "")
                {
                    GlobalMethods.SubmitUserMessage("Woman", _currentUser.UserName, message, userID, roomID);
                    var userMessage = GlobalMethods.GetUserMessages("Woman", roomID);
                    textBoxChat.Text = "";
                    foreach (var item in userMessage)
                    {
                        textBoxChat.Text += string.Format("{0}: {1} ({2}) \r\n", item.Submitter, item.Message, item.TimeStamp.ToShortTimeString());
                    }
                    textBoxMessage.Text = "";
                }
            }
            catch (FaultException ex)
            {
                GlobalMethods.ErrorMessages("Woman", "Service error", ex.Message, roomID, _currentUser.UserName);
                MessageBox.Show("Service error: " + ex.Message);
            }
            catch (Exception ex)
            {
                GlobalMethods.ErrorMessages("Woman", "Client error", ex.Message, roomID, _currentUser.UserName);
                MessageBox.Show("Client error: " + ex.Message);
            }
        }

        private void pictureBoxBin_Click(object sender, EventArgs e)
        {
            var deleteMessages = new DeleteMessages(_currentUser, 3);
            deleteMessages.ShowDialog();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                var userMessage = GlobalMethods.GetUserMessages("Woman", roomID);
                textBoxChat.Text = "";
                foreach (var item in userMessage)
                {
                    textBoxChat.Text += string.Format("{0}: {1} ({2}) \r\n", item.Submitter, item.Message, item.TimeStamp.ToShortTimeString());
                }
            }
            catch (FaultException ex)
            {
                GlobalMethods.ErrorMessages("Woman", "Service error", ex.Message, roomID, _currentUser.UserName);
                MessageBox.Show("Service error: " + ex.Message);
            }
            catch (Exception ex)
            {
                GlobalMethods.ErrorMessages("Woman", "Client error", ex.Message, roomID, _currentUser.UserName);
                MessageBox.Show("Client error: " + ex.Message);
            }
        }
    }
}

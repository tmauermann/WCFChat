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
    public partial class DeleteMessages : Form
    {
        CurrentUser _user;
        int _roomId;
        ChatService.ChatClient _client;
        List<UserMessage> myMessages;

        public DeleteMessages(CurrentUser user, int roomId)
        {
            this._user = user;
            this._roomId = roomId;
            this._client = new ChatService.ChatClient("Unisex");

            InitializeComponent();
            PopulateMyMessages();
        }

        private void PopulateMyMessages()
        {
            myMessages = _client.GetUserMessagesByRoomAndUserId(_roomId, int.Parse(_user.ID)).ToList();

            foreach (var message in myMessages)
            {
                textBoxMyMessages.Text += string.Format("[ID:{0}] Message: {1} \r\n", message.ID, message.Message);
            }
        }

        private void buttonAddForDeletion_Click(object sender, EventArgs e)
        {
            try
            {
                var idInput = int.Parse(textBoxMessageID.Text);
                foreach (var message in myMessages)
                {
                    if (message.ID == idInput)
                        listBoxDeleteMessages.Items.Add(idInput);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input not valid");
            }

        }

        private void buttonDeleteMessages_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxDeleteMessages.Items.Count > 0)
                {
                    foreach (var itemID in listBoxDeleteMessages.Items)
                    {
                        _client.RemoveUserMessage(myMessages.Find(s => s.ID.Equals(itemID)));
                    }
                    MessageBox.Show("Successfully removed message(s)");
                    this.Hide();
                }
                else
                    MessageBox.Show("Nothing to delete...");
            }
            catch (FaultException ex)
            {
                GlobalMethods.ErrorMessages("Unisex", "Service error", ex.Message);
                MessageBox.Show("Service error");
            }
            catch (Exception ex)
            {
                GlobalMethods.ErrorMessages("Unisex", "Client error", ex.Message);
                MessageBox.Show("Client error");
            }
        }
    }
}

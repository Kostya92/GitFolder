using System.Windows.Forms;

namespace EnglishStudyHelper.Services
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowWarning(string message);
        void ShowError(string message);

    }

    public class MessageService : IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}

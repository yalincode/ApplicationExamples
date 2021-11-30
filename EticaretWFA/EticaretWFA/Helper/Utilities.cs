using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EticaretWFA.Helper
{
    public class Utilities
    {
        private readonly static string appName = "Sipariş Ekranı";


        /// <summary>
        /// Hata mesajları için.
        /// </summary>
        /// <param name="message"></param>
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Başarıldı mesajları
        /// </summary>
        /// <param name="message"></param>
        public static void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Soru sorup yanıtını almak için kullanılır.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static DialogResult ShowDialogResultInformationMessage(string message)
        {
            DialogResult result = MessageBox.Show(message, appName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return result;
        }
    }
}

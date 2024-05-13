using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_CuaHangBanDienThoai
{
    public class TripleDES_Class
    {
        // khai báo key 
        private byte[] key;
        // khai báo vecto
        private byte[] iv;
        TripleDESCryptoServiceProvider DES= new TripleDESCryptoServiceProvider();

        public TripleDES_Class()
        {
            // đặt khóa key gồm 24 kí tự bất kì 
            key = System.Text.UnicodeEncoding.UTF8.GetBytes("123*45#hgk&^$#!df*7^3)g-");
            iv = System.Text.UnicodeEncoding.UTF8.GetBytes("456%Q&S#");

        }
        public TripleDES_Class(string _key,string _iv)
        {
            key = System.Text.UnicodeEncoding.UTF8.GetBytes(_key);
            iv=System.Text.UnicodeEncoding.UTF8.GetBytes(_iv);
        }
        // ham ma hoa mat khau 
        public string DecryptPassword(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(password);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;

        }
    }
  
}

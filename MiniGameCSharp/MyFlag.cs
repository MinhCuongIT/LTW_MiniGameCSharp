using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameCSharp
{
    /// <summary>
    /// Đối tượng lưu giữ giá trị của một quốc kì bao gồm đường dẫn, câu hỏi
    /// </summary>
    class MyFlag
    {
        private String path;        //Chứa đường dẫn tới hình lá cờ
        private String question;    //Chứa câu hỏi của lá cờ

        public MyFlag(string path, string question)
        {
            this.path = path;
            this.question = question;
        }

        public string Path { get => path; set => path = value; }
        public string Question { get => question; set => question = value; }
    }
}

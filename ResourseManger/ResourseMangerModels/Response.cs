using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerModels
{
    public class Response<T>
    {
        public Response(T   value){
            ReturnedValue= value;
        }
        public Response(string message,bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }
        public string Message { get; set; } = "no message";
        public T? ReturnedValue { get; set; }
        public bool IsSuccess = true;
    }
}

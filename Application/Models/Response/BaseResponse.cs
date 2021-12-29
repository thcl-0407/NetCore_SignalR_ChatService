using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Application.Models.Response
{
    public class BaseResponse<T>
    {
        public string Message { get; set; }

        public bool IsSuccess { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public T Result { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public IEnumerable<T> Results { get; set; }
    }
}

﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayerApp.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int statusCode { get; set; }
        public string statusMessage { get; set; }
        public List<string> errors { get; set; }


        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> {statusCode = statusCode};
        }
        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomResponseDto<T> { statusCode = statusCode , Data = data};
        }

        public static CustomResponseDto<T> Fail(int statusCode, List<string> errors)
        {
            return new CustomResponseDto<T> { statusCode = statusCode , errors = errors};
        }
        public static CustomResponseDto<T> Fail(int statusCode, string error)
        {
            return new CustomResponseDto<T> { statusCode = statusCode, errors = new List<string> { error } };
        }

    }
}

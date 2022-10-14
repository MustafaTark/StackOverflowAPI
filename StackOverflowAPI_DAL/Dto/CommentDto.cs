﻿using StackOverflowAPI_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowAPI_DAL.Dto
{
    public class CommentDto

    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public DateTime Created { get; set; }
        public LinkedList<Comment>? Replies { get; set; }
    }
}

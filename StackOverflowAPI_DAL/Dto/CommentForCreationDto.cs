﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowAPI_DAL.Dto
{
    public class CommentForCreationDto
    {
        [Required(ErrorMessage = "Comment Content is a required field.")]
        public string? Content { get; set; }
        public DateTime? Created { get; set; }
    }
}

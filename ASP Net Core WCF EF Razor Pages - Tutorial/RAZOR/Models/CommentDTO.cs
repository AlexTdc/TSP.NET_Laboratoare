﻿using RAZOR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAZOR
{
    public class CommentDTO
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int PostPostId { get; set; }
        public virtual PostDTO Post { get; set; }
    }
}
﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Discussion.Models {
    public class Comment {
        
        [MaybeNull]
        public string Country { get; set; } = "by";

        public long Id { get; set; }

        public long TopicId { get; set; }

        [Length(2, 2048)]
        public string Content { get; set; } = null!;
    }

    public class CommentInDto {
        public long TopicId { get; init; }

        [Length(2, 2048)]
        public string Content { get; init; } = null!;
    }

    public class CommentOutDto {
        public long Id { get; init; }

        public long TopicId { get; init; }

        [Length(2, 2048)]
        public string Content { get; init; } = null!;
    }
}

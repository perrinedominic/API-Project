using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment CommentModel)
        {
            return new CommentDto
            {
                Id = CommentModel.Id,
                Title = CommentModel.Title,
                Content = CommentModel.Content,
                CreatedOn = CommentModel.CreatedOn,
                StockId = CommentModel.StockId,
            };
        }
    }
}
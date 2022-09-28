using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReviewProject.Core.DTOs;
using ReviewProject.Core.Models;
using ReviewProject.Core.Services;

namespace ReviewProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : CustomBaseController
    {
        private readonly IServiceGeneric<Comment, CommentDto> _commentService;

        public CommentController(IServiceGeneric<Comment, CommentDto> commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetComment()
        {
            return ActionResultInstance(await _commentService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveComment(CommentDto commentDto)
        {
            return ActionResultInstance(await _commentService.AddAsync(commentDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComment(CommentDto commentDto)
        {
            return ActionResultInstance(await _commentService.Update(commentDto, commentDto.CommentId));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            return ActionResultInstance(await _commentService.Remove(id));
        }
    }
}

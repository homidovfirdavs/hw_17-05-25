using Domain.Entities;
using Infrastructure.Interface;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class BorrowingController(IBorrowingService _borrowingService ) : Controller
{
    
    [HttpGet("getall")]
    public async Task<List<Borrowing>> GetBorrowingsAsync()
    {
        var result = await _borrowingService.GetBorrowingsAsync();
        return result;
    }

    [HttpGet("getbymemberid")]
    public async Task<Borrowing> GetBorrowingByMemberId(int memberId)
    {
        var result = await _borrowingService.GetBorrowingByMemberId(memberId);
        return result;
    }

    [HttpPost("getcreate")]
    public async Task<string> CreateBorrowingAsync(Borrowing borrowing)
    {
        var result = await _borrowingService.CreateBorrowingAsync(borrowing);
        return result;
    }

    [HttpPut("getreturnbook")]
    public async Task<string> ReturnBookAsync(int borrowingId)
    {
        var result = await _borrowingService.ReturnBookAsync(borrowingId);
        return result;
    }
    
}
using Domain.Entities;
using Infrastructure.Interface;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class BookController(IBookService _bookService) : Controller
{
    [HttpGet("getall")]
 public async Task<List<Book>> GetBooksAsync()
 {
     var result =  await _bookService.GetBooksAsync();
     return result;
 }

 [HttpGet("getbyid")]
 public async Task<Book?> GetBookByIdAsync(int id)
 {
     var result = await _bookService.GetBookByIdAsync(id);
     return result;
 }

 [HttpPost("add")]
 public async Task<string> AddBookAsync(Book book)
 {
     var result = await _bookService.AddBookAsync(book);
     return result;
 }

 [HttpPut("update")]
 public async Task<string> UpdateBookAsync(Book book)
 {
     var result = await _bookService.UpdateBookAsync(book);
     return result;
 }

 [HttpDelete("delete")]
 public async Task<string> DeleteBookAsync(int id)
 {
     var result = await _bookService.DeleteBookAsync(id);
     return result;
 }
}
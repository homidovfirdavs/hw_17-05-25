using Domain.Entities;
using Infrastructure.Interface;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class MemberController(IMemberService _memberService) : Controller
{ 
    
    
 [HttpGet("getall")]
 public async Task<List<Member>> GetMembersAsync()
 {
    var result = await _memberService.GetMembersAsync();
    return result;
 }

 [HttpGet("getbyid")]
 public async Task<Member> GetMemberByIdAsync(int id)
 {
     var result = await _memberService.GetMemberByIdAsync(id);
     return result;
 }

 [HttpPost("add")]
 public async Task<string> AddMemberAsync(Member member)
 {
     var result = await _memberService.AddMemberAsync(member);
     return result;
 }

 [HttpPut("update")]
 public async Task<string> UpdateMemberAsync(Member member)
 {
     var result = await _memberService.UpdateMemberAsync(member);
     return result;
 }

 [HttpDelete("delete")]
 public async Task<string> DeleteMemberAsync(int id)
 {
     var result = await _memberService.DeleteMemberAsync(id);
     return result;
 }
 
 

    

}
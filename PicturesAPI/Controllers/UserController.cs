using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PicturesAPI.Data;
using PicturesAPI.Data.Dtos;
using PicturesAPI.Models;
using PicturesAPI.Services;

namespace PicturesAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class UserController : ControllerBase
{
    private UserServices _userServices;

    public UserController(UserServices userServices)
    {
        _userServices = userServices;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDto dto)
    {
        await _userServices.CreateUser(dto);
        return Ok("Created user");
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginUser(LoginUserDto dto)
    {
        return Ok("Authenticated user");
    }
}

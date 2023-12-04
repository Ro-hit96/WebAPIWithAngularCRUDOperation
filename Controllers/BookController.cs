using Microsoft.AspNetCore.Mvc;
using WebAPIBOOK.Model;
using WebAPIBOOK.Service;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IBookService services;

    public BookController(IBookService service)
    {
        this.services = service;
    }


    // GET api-->Book-->getbookbyid-->1
    [HttpGet]
    [Route("GetBooks")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var list = await services.GetBooks();
            return Ok(list);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    // GET api/<BookController>/5
    [HttpGet]
    [Route("GetBookById/{id}")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            var model = await services.GetBookById(id);
            return Ok(model);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    // POST api/<BookController>
    [HttpPost]
    [Route("AddBook")]
    public async Task<IActionResult> Post([FromBody][Bind(include: "Name,Author,Price")] Book book)
    {
        try
        {
            var result = await services.AddBook(book);
            if (result >= 1)
                return StatusCode(StatusCodes.Status201Created);
            else
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable);
            }
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    // PUT api/<BookController>/5
    [HttpPut]
    [Route("UpdateBook")]
    public async Task<IActionResult> Put([FromBody] Book book)
    {
        try
        {
            var result = await services.UpdateBook(book);
            if (result >= 1)
                return StatusCode(StatusCodes.Status201Created);
            else
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable);
            }
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    // DELETE api/<BookController>/5
    [HttpDelete]
    [Route("DeleteBook/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var result = await services.DeleteBook(id);
            if (result >= 1)
                return StatusCode(StatusCodes.Status201Created);
            else
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable);
            }
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
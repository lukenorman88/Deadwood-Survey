﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeadwoodAPI.Models;

namespace DeadwoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveysController : ControllerBase
    {
        private readonly DeadwoodAPIContext _context;

        public SurveysController(DeadwoodAPIContext context)
        {
            _context = context;
        }

        // GET: api/Surveys
        [HttpGet]
        public IEnumerable<Survey> GetSurvey()
        {
            return _context.Survey;
        }

        // GET: api/Surveys/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSurvey([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var survey = await _context.Survey.FindAsync(id);

            if (survey == null)
            {
                return NotFound();
            }

            return Ok(survey);
        }

        // PUT: api/Surveys/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSurvey([FromRoute] int id, [FromBody] Survey survey)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != survey.Id)
            {
                return BadRequest();
            }

            _context.Entry(survey).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurveyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Surveys
        [HttpPost]
        public async Task<IActionResult> PostSurvey([FromBody] Survey survey)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Survey.Add(survey);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSurvey", new { id = survey.Id }, survey);
        }

        // DELETE: api/Surveys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSurvey([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var survey = await _context.Survey.FindAsync(id);
            if (survey == null)
            {
                return NotFound();
            }

            _context.Survey.Remove(survey);
            await _context.SaveChangesAsync();

            return Ok(survey);
        }

        private bool SurveyExists(int id)
        {
            return _context.Survey.Any(e => e.Id == id);
        }
    }
}
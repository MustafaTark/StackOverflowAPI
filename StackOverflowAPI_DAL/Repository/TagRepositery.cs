﻿using Microsoft.EntityFrameworkCore;
using StackOverflowAPI_DAL.Contracts;
using StackOverflowAPI_DAL.Data;
using StackOverflowAPI_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace StackOverflowAPI_DAL.Repository
{
    public class TagRepositery:RepositeryBase<Tag>,ITagRepositery
    {
        public TagRepositery(ApplicationDbContext repositeryContext) : base(repositeryContext)
        {

        }

        public async Task<IEnumerable<Tag?>> GetAllTagsAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Tag?> GetTagAsync(int id, bool trackChanges) =>
            await FindByCondition(t => t.Id == id, trackChanges).FirstOrDefaultAsync()!;
        public void CreateTag(Tag tag) => Create(tag);

        public void DeleteTag(Tag tag)=>
            Delete(tag);
    }
}

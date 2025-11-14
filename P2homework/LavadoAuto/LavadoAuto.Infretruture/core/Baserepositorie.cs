using LavadoAuto.Infretruture.Data;
using LavadoAuto.Infretruture.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  LavadoAuto.Infretruture.core;

public class Baserepositorie<T> : IBaserepositorie<T> where T : class
{
    private readonly LavadoAutosContext _context;
    public Baserepositorie(LavadoAutosContext context)
    {

        _context = context;

    }
    public async Task<T> Getbyid(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
    public async Task<List<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }
    public async Task<T> Create(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
    public async Task<T> Update(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
    public async Task<T> Delete(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
        }
        await _context.SaveChangesAsync();
        return entity;



    }
}

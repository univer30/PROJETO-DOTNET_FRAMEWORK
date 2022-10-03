using Loja.Application.Interfaces;
using Loja.Application.ViewModels;
using Loja.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Application.Services
{
public class LojaMariliaService :ILojaMariliaService
{
    public ILojaMariliaRepository _lojaMariliaRepository;

    public LojaMariliaService(ILojaMariliaRepository lojaMariliaRepository)
    {
         _lojaMariliaRepository = lojaMariliaRepository;
    }
     public LojaMariliaViewModel GetLojaMarilias()
        {
            return new LojaMariliaViewModel()
            {
              LojaMarilias = _lojaMariliaRepository.GetLojaMarilias()
            };
        }
}
}
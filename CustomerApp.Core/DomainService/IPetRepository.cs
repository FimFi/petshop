using System;
using System.Collections.Generic;
using Petshop2020.Core.Entity;

namespace Petshop2020.Core.DomainService
{
    public interface IPetRepository
    {

        Pet Create(Pet pet);
        //Read Data
        Pet ReadyById(int id);
        IEnumerable<Pet> ReadAll();
        //Update Data
        Pet Update(Pet petUpdate);
        //Delete Data
        Pet Delete(int id);
    }
}

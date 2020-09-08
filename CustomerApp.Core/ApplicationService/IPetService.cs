using System;
using System.Collections.Generic;
using Petshop2020.Core.Entity;

namespace Petshop2020.Core.ApplicationService
{
    public interface IPetService
    {
        //New Customer
        Pet NewPet(string Name,
                                string Type,
                                string Color,
                                DateTime BirthDate,
                                DateTime SoldDate,
                                string PreviousOwner,
                                double Price
            
            );

        //Create
        Pet CreatePet(Pet pet);
        //Read
        Pet FindPetById(int id);
        List<Pet> GetAllPets();
        List<Pet> GetAllByType(string type);
        List<Pet> GetAllByPrice();
        List<Pet> ShowFiveCheapest();
        //Update
        Pet UpdatePet(Pet petUpdate);
        
        //Delete
        Pet DeletePet(int id);
    }
}

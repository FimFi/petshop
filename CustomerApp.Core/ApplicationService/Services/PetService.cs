using System;
using System.Collections.Generic;
using System.Linq;
using Petshop2020.Core.DomainService;
using Petshop2020.Core.Entity;

namespace Petshop2020.Core.ApplicationService.Services
{
    public class PetService: ApplicationService.IPetService
    {
        readonly IPetRepository _petRepo;

        public PetService(IPetRepository petRepository)
        {
            _petRepo = petRepository
                ;
        }

        public Pet NewPet(string Name, string Type, string Color, DateTime BirthDate, DateTime SoldDate, string PreviousOwner, double Price)
        {
            var pet = new Pet()
            {
                Name = Name,
                Type = Type,
                Color = Color,
                BirthDate = BirthDate,
                SoldDate = SoldDate,
                PreviousOwner = PreviousOwner,
                Price = Price
            };

            return pet;
        }

        public Pet CreatePet(Pet pet)
        {
            return _petRepo.Create(pet);
        }

        public Pet FindPetById(int id)
        {
            return _petRepo.ReadyById(id);
        }

        public List<Pet> GetAllPets()
        {
            return _petRepo.ReadAll().ToList();
        }

        public List<Pet> GetAllByType(string name)
        {
            var list = _petRepo.ReadAll();
            var queryContinued = list.Where(pet => pet.Name.Equals(name));
            queryContinued.OrderBy(pet => pet.Name);
            return queryContinued.ToList();
        }

        public List<Pet> GetAllByPrice()
        {
            var list = _petRepo.ReadAll();
            var queryOrdered = list.OrderBy(pet => pet.Price);
            return queryOrdered.ToList();
        }

        public List<Pet> ShowFiveCheapest() 
        {
            var list = _petRepo.ReadAll();
            var queryOrdered = list.OrderBy(Pet => Pet.Price);
            var firstFiveItems = queryOrdered.Take(5);
            return firstFiveItems.ToList();
        }

        public Pet UpdatePet(Pet petUpdate)
        {
            var pet = FindPetById(petUpdate.Id);
            pet.Name = petUpdate.Name;
            pet.Type = petUpdate.Type;
            pet.Color = petUpdate.Color;
            pet.BirthDate = petUpdate.BirthDate;
            pet.SoldDate = petUpdate.SoldDate;
            pet.PreviousOwner = petUpdate.PreviousOwner;
            pet.Price = petUpdate.Price;
            return pet;
        }

        public Pet DeletePet(int id)
        {
            return _petRepo.Delete(id);
        }
    }
}

using System.Collections.Generic;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Contracts
{
    public interface IAttractionService
    {
        IEnumerable<AttractionEntity> GetAllAttractions();
        AttractionEntity GetAttractionById(string AttractionId);
        void CreateAttraction(AttractionEntity attraction, string currentAttractionId);
        void UpdateAttraction(AttractionEntity attraction, string currentAttractionId);
    }
}

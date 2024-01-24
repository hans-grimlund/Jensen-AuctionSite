using Auktionssajt.Core.Interfaces;
using Auktionssajt.Data.Interfaces;
using Auktionssajt.Data.Repository;
using Auktionssajt.Domain.Entities;
using Auktionssajt.Domain.Models;

namespace Auktionssajt.Core.Services
{
    public class BidService : IBidService
    {
        private readonly BidRepo _bidRepo = new();
        private readonly MappingService _mappingService = new();

        public void DeleteBid(int id)
        {
            _bidRepo.DeleteBid(id);
        }

        public List<BidEntity> GetBidList(int id)
        {
            var bids = _bidRepo.GetBidsFromAuction(id);
            return bids;
        }

        public Status InsertBid(NewBidModel newBid)
        {
            var bidEntity = _mappingService.NewBidModeltoBidEntity(newBid);
            _bidRepo.InsertBid(bidEntity);
        }
    }
}
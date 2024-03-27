using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseStudy;
using CaseStudy.Repository;

namespace CaseStudyApp.nUnitTests
{
    internal class LeaseCreated
    {
        public void CreateLease_Success()
        {
            // Arrange: Prepare the necessary data and dependencies
            CarLeaseRepositoryImpl leaseRepository = new CarLeaseRepositoryImpl(); 
            Lease leaseToCreate = new Lease
            {
                LeaseID = 1,
                VehicleID = 1,
                CustomerID = 1,
                StartDate = new DateTime(2022, 3, 1),
                EndDate = new DateTime(2022, 3, 31),
                Type = "Standard"
            }; ; // Example lease data

            // Act: Perform the action (create a lease)
            bool creationResult = leaseRepository.CreateLease();

            // Assert: Verify the outcome
            Assert.IsTrue(creationResult, "Lease creation should succeed");

            // Optionally, you can also verify if the lease is added to the repository or database
            //Assert.IsTrue(leaseRepository.Contains(leaseRepository.CreateLease()), "Lease should be added to the repository");
        }
    }
}

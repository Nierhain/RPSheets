using AutoBogus;
using Moq;
using RPSheets.Data;
using RPSheets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Mocks
{
    public class MockRepository<T> where T : class
    {
        private Mock<IDbRepository> _mockInstance;
        private IDbRepository _repository;
        private List<T> _mockData;

        public MockRepository(int toGenerate)
        {
            _mockData = AutoFaker.Generate<T>(toGenerate);
            _mockInstance = new Mock<IDbRepository>();
            _repository = _mockInstance.Object;

            _mockInstance.Setup(x => x.ReadList<T>()).ReturnsAsync(_mockData);

            _mockInstance.Setup(x => x.Read<T>()).ReturnsAsync();
        }
    }
}

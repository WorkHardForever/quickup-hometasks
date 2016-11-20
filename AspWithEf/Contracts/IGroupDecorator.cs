using AspWithEf.Models;

namespace AspWithEf.Contracts
{
    interface IGroupDecorator
    {
        bool Create(Group newGroup);
        Group Read(int id);
        bool Delete(int id);
        bool Update(int id, Group group);
    }
}

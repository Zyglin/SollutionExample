using System.ComponentModel.DataAnnotations;

namespace Lesson15.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    //��� ������ ������������ �� �������, ������� ����� ��������� � ���� ������.
}
//����� ����������������� � ����� ������ ����� EF ��� ����� �������� ������(�����, �������������� �� ������ Microsoft.EntityFrameworkCore.DbContext).

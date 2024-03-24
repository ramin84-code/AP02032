#include<iostream>
using namespace std;

class student{
private:
    string name;
    string student_id;
    int age;
    char *courses[100];

public:
    student(string Name, string Student_id, int Age, const char* course) {
        name = Name;
        student_id = Student_id;
        age = Age;
        course = (char*)malloc(100);
    }
    void Add_student(){
        courses.
    }

};
int main(){
    return 0;
}
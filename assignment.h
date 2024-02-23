#include <iostream>
#include <string>
#include <vector>


using namespace std;
class Student {
    friend class Course;
    
private:
    string name;
    vector<int> grades;

public:
    Student(const string& studentName):name(studentName) {}

    void get_grades(int* Graids){
        int *grades = (int*)malloc(sizeof(Graids)*sizeof(int));
        for (int i =0;i<sizeof(Graids);i++) grades[i] = Graids[i];
        free(grades);
        grades = Graids;
        Graids = NULL;
    }
    void addGrade(int grade) {
        grades.push_back(grade);
    }

    double getAverageGrade() const {
        int sum =0;
        for (int i =0;i<sizeof(grades);i++) sum +=grades[i];
        return sum/sizeof(grades);
    }

    string getName() const {
        return name;
    }
};

class Course   {
private:
    string courseName;
    string instructorName;
    vector<Student> students;
    Student& student;

public:
    Course(const string& name, const string& instructor,Student& Students ): courseName(name), instructorName(instructor), student(Students){}

    void addStudent(const Student& student) {
        students.push_back(student.name);
    }

    double getCourseAverage() const {
        int s=0;
        for (int i =0;i<sizeof(students);i++){
            s += student.getAverageGrade();
        }
        double average = s/sizeof(students);
        return average;
    }

    string displayStudentGrades(const string& studentName) const {
        
        if (studentName == student.name)   {
            cout << "the grades for "+ studentName+"are:";
            for (int j = 0;j<sizeof(student.grades);j++){cout << student.grades[j];}
        }
        else{
            cout << "The student was not found";
        }
    }
    
    };

class Instructor {
private:
    string instructorName;
    Course& course;
    Student& student;

public:
    Instructor(const string& name, Course& courseObj, Student& studentObj)
    :instructorName(name), course(courseObj),student(studentObj){}
    
    void changeGrade(const string& studentName, int newGrade) {
        student.addGrade(newGrade);
        course.displayStudentGrades(studentName);
    }
};


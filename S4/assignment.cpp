#include "assignment.h"
int main() {


    Student student1("Alice");
    student1.addGrade(90);
    student1.addGrade(85);
    student1.addGrade(95);
    Course course("Programming 101", "John Doe",student1);
    course.addStudent(student1);

    Student student2("Bob");
    student2.addGrade(75);
    student2.addGrade(80);
    student2.addGrade(70);
    Course course("Programming 101", "John Doe", student2);
    course.addStudent(student2);

    // Calculate and display the average grade for the course
    double courseAverage = course.getCourseAverage();
    std::cout << "Average grade for the course: " << courseAverage << std::endl;

    // Display grades for a specific student
    course.displayStudentGrades("Alice");

    // Instructor changes a student's grade
    Instructor instructor("Jane Smith", course,student1);
    instructor.changeGrade("Bob", 85);

    // Display updated grades for the student
    course.displayStudentGrades("Bob");

    return 0;
}
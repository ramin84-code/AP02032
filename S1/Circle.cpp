#include <iostream>
#include<math.h>
using namespace std;
class Point{
public:
    int x;
    int y;

    Point(int m_x, int m_y): x(m_x), y(m_y){}
    double DistanceTo(const Point& p)const{
        return sqrt((x-p.x)^2+(y-p.y)^2);
    }
};


class circle{

    Point d;
    double radius;
public:
    circle(const Point& p,double rad):
    d(p), radius(rad) {}


    double Circumference(){return 2*M_PI*radius;}//returns the periemeter of the circle
    double Area(){return radius*radius*M_PI;};
    double DistanceTo(const circle& c)const{
        return d.DistanceTo(c.d);
        
    };// it should calculate the distance of a circle to another circle.
    double DistanceTo(const Point& p){// it should show the distance between centers of two circles.
        return p.DistanceTo( d);
}
};

int main(){
    Point p(1,1);
    circle c(Point(5,4),4);
    
    circle c1(Point(3,2),5);


    cout << c.Circumference() <<endl;
    cout << c.Area()<< endl;
    cout << c.DistanceTo(c1) << endl;
    cout << c.DistanceTo(p) << endl;
    return 0;
}
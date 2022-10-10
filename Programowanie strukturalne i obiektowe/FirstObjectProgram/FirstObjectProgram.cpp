#include <iostream>

class Point
{
public:
    
    double calculateDistance()
    {
        double distance = sqrt(x * x + y * y);
        return distance;
    }

    void SetX(int x)
    {
        //zak�adamy �e jeste�my tylko w pierwszej �wiartce uk�adu XY
        if (x >= 0)
            this->x = x;
    }

    void SetY(int y)
    {
        //zak�adamy �e jeste�my tylko w pierwszej �wiartce uk�adu XY
        if (y >= 0)
            this->y = y;
    }

protected:

private:
    int x;
    int y;    
};

int main()
{
    Point point;
    //point.x = 10;
    point.SetX(10);
    point.SetY(15);
    double distance = point.calculateDistance();
    std::cout << "Dystans od punktu (0;0) = " << distance << "\n";

}
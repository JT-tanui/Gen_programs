#include <iostream>
#include <vector>
using namespace std;

int main() {
    // ArrayList (Vector)
    std::vector<int> arrayList = {1, 2, 3, 4, 5};
    std::cout << "ArrayList: ";
    for (int i : arrayList) {
        std::cout << i << " ";
    }
    std::cout << std::endl;

    // Accessing elements by index
    std::cout << "Accessing element at index 2: " << arrayList[2] << std::endl;

    // Modifying elements by index
    arrayList[2] = 9;
    std::cout << "Modified ArrayList: ";
    for (int i : arrayList) {
        std::cout << i << " ";
    }
    std::cout << std::endl;

    // Inserting elements at a specific index
    arrayList.insert(arrayList.begin() + 2, 8);
    std::cout << "ArrayList after inserting 8 at index 2: ";
    for (int i : arrayList) {
        std::cout << i << " ";
    }
    std::cout << std::endl;

    // Deleting elements at a specific index
    arrayList.erase(arrayList.begin() + 2);
    std::cout << "ArrayList after deleting element at index 2: ";
    for (int i : arrayList) {
        std::cout << i << " ";
    }
    std::cout << std::endl;

    return 0;
}

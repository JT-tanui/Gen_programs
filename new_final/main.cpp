#include <iostream>
#include <stack>
#include <algorithm>
#include <vector>
using namespace std;

int array[10] = {15, 8, 12, 1, 9, 3};

// Function to find an element in the array
int findElement(int arr[], int n, int key) {
    for (int i = 0; i < n; i++) {
        if (arr[i] == key) {
            return i;
        }
    }
    return -1;
}

// Function to push an element to the stack
void pushElement(stack<int> &myStack, int value) {
    myStack.push(value);
    cout << "You have pushed: " << value << endl;
}

// Function to peek an element in the stack
void peekElement(stack<int> &myStack) {
    if (!myStack.empty()) {
        cout << "/n" << "You are peeking: " << myStack.top() << endl;
    } else {
        cout << "/n" << "Stack is empty. Cannot handle the peek." << endl;
    }
}

// Function to pop an element from the stack
void popElement(stack<int> &myStack) {
    if (!myStack.empty()) {
        cout << "/n" << "You are removing: " << myStack.top() << endl;
        myStack.pop();
    } else {
        cout << "/n" << "Stack is empty. Cannot handle the pop." << endl;
    }
}

// Function to display the stack
void displayStack(stack<int> &myStack) {
    if (myStack.empty()) {
        cout << "/n" << "Stack is empty." << endl;
    } else {
        cout << "/n" << "Stack elements are: ";
        while (!myStack.empty()) {
            cout << myStack.top() << " ";
            myStack.pop();
        }
        cout << endl;
    }
}

// Function to handle the different operations
void handleOperation(int choice, stack<int> &myStack) {
    int value;
    switch (choice) {
        case 1:
            cout << "Enter the value to push: ";
            cin >> value;
            pushElement(myStack, value);
            break;
        case 2:
            cout << "Enter the value to search: ";
            cin >> value;
            peekElement(myStack, value);
            break;
        case 3:
            popElement(myStack);
            break;
        case 4:
            sortStack(myStack);
            break;
        case 5:
            displayStack(myStack);
            break;
        default:
            cout << "Invalid choice. Please try again." << endl;
            break;
    }
}

int main() {
    stack<int> myStack;

    int choice;
    do {
        cout << "1. Push an element to the stack" << endl;
        cout << "2. Search an element in the stack" << endl;
        cout << "3. Pop an element from the stack" << endl;
        cout << "4. Sort the stack" << endl;
        cout << "5. Display the stack" << endl;
        cout << "0. Exit" << endl;
        cout << "Enter your choice: ";
        cin >> choice;
        handleOperation(choice, myStack);
    } while (choice != 0);

    return 0;
}

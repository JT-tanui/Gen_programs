#include <iostream>
#include <stack>
#include <algorithm>
#include <vector>
#include <bits/stdc++.h>
using namespace std;

int array = {15,8,12,1,9,3};
// Function to implement search operation
int findElement(int arr[], int n, int key)
{
	int i;
	for (i = 0; i < n; i++)
		if (arr[i] == key)
			return i;

	// If the key is not found
	return -1;
}

// Driver's Code
int main()
{
	int arr[] = {15,8,12,1,9,3};
	int n = sizeof(arr) / sizeof(arr[0]);

	// Using a last element as search element
	int key = 8;

	// Function call
	int position = findElement(arr, n, key);

	if (position == -1)
		cout << "Element not found";
	else
		cout << "Element Found at Position: "
			<< position + 1;

}


// Function to add an element to the stack
void pushElement(stack<int> &myStack, int value) {
    myStack.push(value);
    cout << "Pushed: " << value << endl;
}
// function to search an element to the stack
void peekElement(stack<int> &mystack,int value){
   mystack.peek(value);
   cout<<"Searched: " << value << endl
   }
// Function to delete the top element from the stack
void popElement(stack<int> &myStack) {
    if (!myStack.empty()) {
        cout << "Popped: " << myStack.top() << endl;
        myStack.pop();
    } else {
        cout << "Stack is empty. Cannot pop." << endl;
    }
}

// Function to sort the elements in the stack
void sortStack(stack<int> &myStack) {
    // Convert the stack to a vector for sorting
    vector<int> tempVector;
    while (!myStack.empty()) {
        tempVector.push_back(myStack.top());
        myStack.pop();
    }

    // Sort the vector in ascending order
    sort(tempVector.begin(), tempVector.end());

    // Push the sorted elements back into the stack
    for (int i = tempVector.size() - 1; i >= 0; --i) {
        myStack.push(tempVector[i]);
    }
}

int main() {
    stack<int> myStack;

    // Add elements to the stack
    pushElement(myStack, 15);
    pushElement(myStack, 8);
    pushElement(myStack, 12);
    pushElement(myStack, 1);
    pushElement(myStack, 9);
    pushElement(myStack, 3);

    // Searching for element to the stack
    peekElement(myStack,8);
    // Delete an element from the stack
    popElement(myStack.top);
    // Sort the elements in the stack
    sortStack(myStack);
    // Display the sorted elements
    cout << "Sorted stack elements: ";
    while (!myStack.empty()) {
        cout << myStack.top() << " ";
        myStack.pop();
    }

    return 0;
}








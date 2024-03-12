#include <iostream>

const int MAX_SIZE = 10;

class Stack {
private:
    int arr[MAX_SIZE];
    int top;

public:
    Stack() { top = -1; }

    bool is_empty() { return top == -1; }

    bool is_full() { return top == MAX_SIZE - 1; }

    void push(int x) {
        if (!is_full()) {
            arr[++top] = x;
        } else {
            std::cout << "Stack is full. Cannot push " << x << " to the stack.\n";
        }
    }

    int pop() {
        if (!is_empty()) {
            return arr[top--];
        } else {
            std::cout << "Stack is empty. Cannot pop from the stack.\n";
            return -1;
        }
    }

    int get_top() {
        if (!is_empty()) {
            return arr[top];
        } else {
            std::cout << "Stack is empty.\n";
            return -1;
        }
    }

    void print_stack() {
        std::cout << "Stack: ";
        for (int i = 0; i <= top; i++) {
            std::cout << arr[i] << " ";
        }
        std::cout << std::endl;
    }
};

int main() {
    Stack stack;

    stack.push(1);
    stack.push(2);
    stack.push(3);
    stack.push(4);
    stack.push(5);

    stack.print_stack();

    std::cout << "Top element is: " << stack.get_top() << "\n";

    stack.pop();
    stack.pop();

    stack.print_stack();

    std::cout << "Top element is: " << stack.get_top() << "\n";

    return 0;
}

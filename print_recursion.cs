using System;

static void print_recursion(ref int[] arr, int pos=0) {
    int pos_from_end = arr.Length - pos;
    if (pos_from_end <= 0) {
        return;
    } else {
        Console.WriteLine(arr[pos_from_end]);
        print_recursion(ref arr, pos + 1);
    }
}

int[] ints = {1, 2, 3, 4, 5, 6, 7};
print_recursion(ref ints);


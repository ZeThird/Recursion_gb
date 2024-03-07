using System;

static void m_to_n(int m, int n) {
    Console.WriteLine(m);
    if (m >= n) {
        return;
    } else {
        m_to_n(m + 1, n);
    }
}

m_to_n(5, 10);

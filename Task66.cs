// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < n) {
    int sum = 0;
    int Summ(int M, int N) {
        if (M == N + 1) return 0;
        Summ(M + 1, N);
        sum = sum + M;
        return sum;
    }
    Console.WriteLine(Summ(m,n));
}
else {
    int sum = 0;
    int Summ(int M, int N) {
        if (M == N - 1) return 0;
        Summ(M - 1, N);
        sum = sum + M;
        return sum;
    }
    Console.WriteLine(Summ(m,n));
}
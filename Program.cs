// Desenvolver um algoritmo que calcule a idade média dos alunos de uma classe da faculdade,
// sabendo que o aluno mais novo tem 20 anos e o mais velho tem 50 anos, utilize a
// seguinte fórmula para calcular: MEDIA ALUNO = (IDADE MÍNIMA + IDADE MÁXIMA) / 2

int idadeMin = 20;
int idadeMax = 50;
int mediaIdade = 0;

mediaIdade = (idadeMin + idadeMax) / 2;

Console.WriteLine($"A idade média da classe é de: {mediaIdade} anos");
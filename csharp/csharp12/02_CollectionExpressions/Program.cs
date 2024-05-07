// before C#12
int[] oldWayForArray1 = new int[] { 1, 2, 3, 4 };
int[] oldWayForArray2 = new [] { 1, 2, 3, 4 };
int[] oldWayForArray3 =  { 1, 2, 3, 4 };

// C#12
int[] array = [1, 2, 3, 4];

List<int> myList = [1, 2, 3, 4];

int[][] twoDArray = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [7, 8, 9];
int[][] twoDFromVariables = [row0, row1, row2];

int[] single = [..row0, ..row1, ..row2]; // 1, 2, 3, 4, 5, 6, 7, 8, 9,

int[] single2 = [..row0, 37, ..row1, 86, 12, ..row2]; // 1, 2, 3, 37, 4, 5, 6, 86, 12, 7, 8, 9
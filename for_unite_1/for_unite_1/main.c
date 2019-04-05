//
//  main.c
//  for_unite_1
//
//  Created by dodo on 23/03/2019.
//  Copyright © 2019 olesya. All rights reserved.
//

#include <stdio.h>

int main(int argc, const char * argv[]) {
    // insert code here...
    printf("Hello, World!\n");
    
    int a = 40;
    printf("переменная имеет значение: %d \n", a);
    printf("переменная находится по адресу: %p \n", &a);
    
    int input;
    printf("введи число:");
    scanf("%d", &input);
    printf("мы удвоили число: %d\n", input*2);
    
    return 0;
    
}

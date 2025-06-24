#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#pragma warning(disable: 4996)
#define ANSI_COLOR_RED     "\x1b[31m"
#define ANSI_COLOR_GREEN    "\x1b[32m"
#define ANSI_COLOR_YELLOW  "\x1b[33m"
#define ANSI_COLOR_BLUE    "\x1b[34m"
#define ANSI_COLOR_MAGENTA "\x1b[35m"
#define ANSI_COLOR_RESET   "\x1b[0m"


struct simple_user
{
	char username[20], password[20], email[30];
	int codemelli;
	char csalamat[10][15];
	char name[20], family[20], confirm_password[20], blood[10];
	int age, height, weight;
	time_t salamat_date[10];
	
};


struct bussiness_user
{
	char username[20], password[20], email[30];
	int codemelli;
	char vazeiat[10];
	char name[20], family[20], confirm_password[20], store[20], city[20];
	int reigon;
};

struct simple_user simuser[100] = {
		{"hossein","ebadi","hossein@gmail.com",123456,"0(empty)","hossein","ebadi","ebadi","b",18,180,70,0},
		{"soheil","ebadi","soheil@gmail.com",1273752902,"0(empty)","soheil","ebadi","ebadi","a",18,169,70,0}
};

struct bussiness_user bususer[100] = {
	{"sepehr","ebadi","sepehr@gmail.com",1273752910,"0(empty)","sepehr","ebadi","ebadi","sepstore","isfahan",3},
    {"alireza","ebadi","alireza@gmail.com",123456,"0(empty)","alireza","ebadi","ebadi","alirstore","tehran",6}
};
//struct simple_user simuser_sign[100];
FILE* fp;
FILE* fp_bus;
FILE* fp_user;
//int user = 2;


//char simple2[20] = "soheil";
//char passsimple2[20] = "ebadi";
//char emailsimple2[] = "soheilgmail.com";
//int code_simple2 = 1273752902;

//char simple1[20] = "hossein";
//char passsimple1[20] = "ebadi";
//char emailsimple1[] = "hosseingmail.com";
//int code_simple1 = 123456;


char job2[20] = "sepehr";
char passjob2[20] = "ebadi";
char emailjob2[] = "sepehrgmail.com";
int code_job2 = 1273752910;

char job1[20] = "alireza";
char passjob1[20] = "ebadi";
char emailjob1[] = "alirezagmail.com";
int code_job1 = 123456;



char admin[20] = "mpssebadi";
char passadmin[20] = "mpss";



//char csalamat_login1[30] = "0(empty)";
//char csalamat_login2[30] = "0(empty)";
//char csalamat1[30] = "0(empty)";
//char csalamat[10][30] = { "0(empty)" };
//char csalamat_login[10][30] = { "0(empty)" };
//char csalamat_login1_health[10][30] = { "0(empty)" };

//int o = 0;
//int w = 0;
//int i = 0;

//char vaz1_login[10] = "RED";
//char vaz2_login[10] = "WHITE";
//char vaz1_login1[10] = "RED";
//char vaz2_login1[10] = "WHITE";

char vaz1[10] = "RED";
char vaz2[10] = "WHITE";

char namesimple[30], familysimple[30], usernamesimple1[30], passwordsimple1[30], confpasswordsimple1[30], emailsimple[30],blood[30];
int codesimple, age, height, weight;


char namebus[30], familybus[30], usernamebus1[30], passwordbus1[30], confpasswordbus1[30], emailbus[30], store[30], city[30];
int codebus, reigon;

//int* codemeli_visit_simple[10] = {};

int m = 0;
char ch;
int n = 0;
char ch2;
int k = 0;
char ch3;
int p = 0;
char ch4;
int q = 0;
char ch5;
int r = 0;
char ch6;


//char codemeli_visit[10][20];
//int z = 0;

//
//time_t health[10];
//int u = 0;
//time_t health_login[10];
//int e = 0;
//time_t health_login1[10];
//int t = 0;
//time_t vpeople_sign[10];
//int cv_sign = 0;
//
//char name_visit[10][30];
//int cn_sign = 0;
int time_counter = 0;
int sdate = 0;

void login();
void menu();
void forget();
void sign_up();
void menu_simple();
void menu_bus();
//void editsimple();
void editbus();
void visit_people();
void visit_place();
void tarikh_heathness(int y,int x);
void tarikh_people(int y,int x);
void tarikh_place();

/////////////////////////    login     ///////////////////////////////////////////////////
void login()
{
	
	char username[30], password[30];
	char username1[30], password1[30];
	
	int koodom;
	printf("\nWhich Type Of Account ?\n1.SIMPLE\n2.BUSSINESS\n\n");
	scanf("%d", &koodom);
	int i = 0;
	char ch;
	int i1 = 0;
	char ch1;
	char line[500];
	int ok = 0;
	char line1[500];
	int ok1 = 0;
	switch (koodom)
	{
	tekrar:case 1:
		//fp = fopen("simple_user.txt", "r+");

		printf(ANSI_COLOR_RED "Enter Username:" ANSI_COLOR_RESET "\n");
		scanf("%s", username);
		fp_user = fopen(username, "r+");
		
		printf(ANSI_COLOR_RED "Enter Password:" ANSI_COLOR_RESET" \n");

		

		while (1)
		{

			//scanf("%c", &ch);
			ch = getch();

			if (ch == 13)
			{
				password[i] = '\0';
				break;
			}
			else if (ch == 8)
			{
				if (i > 0)
				{
					i--;
					printf("\b \b");
				}
			}
			else if (ch == 9 || ch == 32)
			{
				continue;
			}
			else
			{
				password[i] = ch;
				i++;
				printf("*");
			}
		}
		
		//char ufind[30];
		//char pfind[30];
		while (fscanf(fp_user, "%s", line) != EOF)
		{

			if (strstr(line, username) && strstr(line, password))
			{
				
				menu_simple();
				ok = 1;
			}
		}
		fclose(fp_user);
		if (!ok)
		{
			printf("\n\nYou Have Not An Account previously\n\n");
			menu();
			/*puts("Try Again ?\n1.Yes\n2.No\n");
			int ar;
			scanf("%d", &ar);
			if (ar == 1) goto tekrar;
			else  menu();*/

		}
		break;

	tekrar1:case 2:
		//fp_bus = fopen("bus_user.txt", "r+");
	    printf(ANSI_COLOR_RED "Enter Username:" ANSI_COLOR_RESET "\n");
		scanf("%s", username1);
		fp_user = fopen(username, "r+");
		printf(ANSI_COLOR_RED "Enter Password:" ANSI_COLOR_RESET" \n");

		

		while (1)
		{

			//scanf("%c", &ch);
			ch1 = getch();

			if (ch1 == 13)
			{
				password1[i1] = '\0';
				break;
			}
			else if (ch1 == 8)
			{
				if (i1 > 0)
				{
					i1--;
					printf("\b \b");
				}
			}
			else if (ch1 == 9 || ch1 == 32)
			{
				continue;
			}
			else
			{
				password1[i1] = ch1;
				i1++;
				printf("*");
			}
		}
		
		//char ufind[30];
		//char pfind[30];
		while (fscanf(fp_user, "%s", line1) != EOF)
		{

			if (strstr(line1, username1) && strstr(line1, password1))
			{
				menu_bus();
				ok1 = 1;
			}
		}
		fclose(fp_user);
		if (!ok1)
		{
			printf("\n\nYou Have Not An Account previously\n\n");
			menu();
			/*puts("Try Again ?\n1.Yes\n2.No\n");
			int ar1;
			scanf("%d", &ar1);
			if (ar1 == 1) goto tekrar1;
			else  menu();*/

		}
		break;

	default:
		printf("\nWrong Choice\n");
		login();
		break;
	}


	//printf(ANSI_COLOR_RED "Enter Username:" ANSI_COLOR_RESET "\n");
	//scanf("%s", username);

	//printf(ANSI_COLOR_RED "Enter Password:" ANSI_COLOR_RESET" \n");
	//
	//int i = 0;
	//char ch;

	//while (1)
	//{
	//	
	//	//scanf("%c", &ch);
	//	ch = getch();
	//
	//	if (ch == 13)
	//	{
	//		password[i] = '\0';
	//		break;
	//	}
	//	else if (ch == 8)
	//	{
	//		if (i > 0)
	//		{
	//			i--;
	//			printf("\b \b");
	//		}
	//	}
	//	else if (ch == 9 || ch == 32)
	//	{
	//		continue;
	//	}
	//	else
	//	{
	//		password[i] = ch;
	//		i++;	
	//		printf("*");
	//	}
	//}
	//char line[500];
	//int ok = 0;
	////char ufind[30];
	////char pfind[30];
	//while (fscanf(fp, "%s", line) != EOF)
	//{

	//	if (strstr(line,username) && strstr(line, password))
	//	{
	//		menu_simple();
	//		ok = 1;
	//	}
	//}
	//	
	//if (!ok)
	//{
	//		printf("\n\nYou Have Not An Account previously\n\n");
	//		puts("Try Again ?\n1.Yes\n2.No\n");
	//		int ar;
	//		scanf("%d", &ar);
	//		if (ar == 1) login();
	//		else  menu();
	//		
	//}
	//

	
	//printf("\n\n\t\t ENter succesfully\n\n");
	//getchar();
	//menu_simple();
	/*if ((strcmp(username,simuser[0].username) == 0) && (strcmp(password,simuser[0].password) == 0))
	{
		menu_simple();
	}

	else if ((strcmp(username,simuser[1].username) == 0) && (strcmp(password,simuser[1].password) == 0))
	{
		menu_simple();
		
	}

	else if ((strcmp(username, job2) == 0) && (strcmp(password, passjob2) == 0))
	{
		
	}

	else if ((strcmp(username, job1) == 0) && (strcmp(password, passjob1) == 0))
	{
		
	}


	else if (strcmp(username, admin) == 0 && strcmp(password, passadmin) == 0)
	{

		printf("you are succesfully enter as an admin\n");
		exit(0);

	}

	else
	{
		puts(ANSI_COLOR_YELLOW "\nYOU DONT HAVE AN ACCOUNT Previously\n" ANSI_COLOR_RESET);
		puts("\n");
		puts("\n");
		menu();
	}
*/

}

////////////////////////     signup   ////////////////////////////////////////////////////

void sign_up()
{

	int type;
loop: 
	printf("Choose your account type:\n");
	printf("1.simple account\n2.business account\n");
	scanf("%d", &type);
	

	switch (type)
	{
		
		/*char namesimple[30], familysimple[30], usernamesimple1[30], passwordsimple1[30], confpasswordsimple1[30], emailsimple[30], blood[30];
		int codesimple, age, height, weight;*/

	case(1):
		//fp = fopen("simple_user.txt", "a+");
		
		printf("Username:*\n");
		scanf("%s", simuser->username);
		fp_user = fopen(simuser->username, "w");
		fprintf(fp_user, "%s%s,", "username:", simuser->username);



		printf("Password:*\n");
		//scanf("%s", passwordsimple1);

		while (1)
		{

			//scanf("%c", &ch);
			ch = getch();

			if (ch == 13)
			{
				simuser->password[m] = '\0';
				break;
			}
			else if (ch == 8)
			{
				if (m > 0)
				{
					m--;
					printf("\b \b");
				}
			}
			else if (ch == 9 || ch == 32)
			{
				continue;
			}
			else
			{
				simuser->password[m] = ch;
				m++;
				printf("*");
			}
		}
		fprintf(fp_user, "%s%s,", "password:", simuser->password);

		printf("\nConfirm Password:*\n");
		//scanf("%s", confpasswordsimple1);

		while (1)
		{

			//scanf("%c", &ch);
			ch2 = getch();

			if (ch2 == 13)
			{
				simuser->confirm_password[n] = '\0';
				break;
			}
			else if (ch2 == 8)
			{
				if (n > 0)
				{
					n--;
					printf("\b \b");
				}
			}
			else if (ch2 == 9 || ch2 == 32)
			{
				continue;
			}
			else
			{
				simuser->confirm_password[n] = ch2;
				n++;
				printf("*");
			}
		}
		fprintf(fp_user, "%s%s,", "conf_password:", simuser->confirm_password);



		while (strcmp(simuser->confirm_password, simuser->password) != 0)
		{
			printf("\nError For confirm password\n");
			printf("\nConfirm Password:\n");



			while (1)
			{


				//scanf("%c", &ch);
				ch3 = getch();

				if (ch3 == 13)
				{
					simuser->confirm_password[k] = '\0';
					break;
				}
				else if (ch3 == 8)
				{
					if (k > 0)
					{
						k--;
						printf("\b \b");
					}
				}
				else if (ch3 == 9 || ch3 == 32)
				{
					continue;
				}
				else
				{
					simuser->confirm_password[k] = ch3;
					k++;
					printf("*");
				}
			}

			fprintf(fp_user, "%s%s,", "conf_password:", simuser->confirm_password);

			continue;
		}

		printf("Name*:\n");
		scanf("%s",simuser->name);
		fprintf(fp_user, "%s%s,", "name:",simuser->name);
		

		printf("Family Name*:\n");
		scanf("%s", simuser->family);
		fprintf(fp_user, "%s%s,", "family:",simuser->family);


		printf("Code Melli*:\n");
		scanf("%d", &simuser->codemelli);
		fprintf(fp_user, "%s%d,","melli:", simuser->codemelli);




		
		printf("\nEmail Adress:*\n");
		scanf("%s", simuser->email);
		fprintf(fp_user, "%s%s,","email:", simuser->email);


		
		
		printf("Blood Type:\n");
		scanf("%s", simuser->blood);
		fprintf(fp_user, "%s%s,","blood:", simuser->blood);

		
		
		

		printf("Age:\n");
		scanf("%d", &simuser->age);
		fprintf(fp_user, "%s%d,","age:", simuser->age);


		printf("Height:\n");
		scanf("%d", &simuser->height);
		fprintf(fp_user, "%s%d,","height:", simuser->height);


		printf("Weight:\n");
		scanf("%d", &simuser->weight);
		fprintf(fp_user, "%s%d,","weight:", simuser->weight);

		

		strcpy(simuser->csalamat[sdate], "0(empty)");
		fprintf(fp_user, "%s%s\n", "csalamat:",simuser->csalamat[sdate]);
		fclose(fp_user);
		
		//user++;
		menu_simple();
		break;

	case(2):
		
		/*char namebus[30], familybus[30], usernamebus1[30], passwordbus1[30], confpasswordbus1[30], emailbus[30], store[30], city[30];
		int codebus, reigon;*/

		printf("Name:*\n");
		scanf("%s", namebus);
		


		printf("Family Name:*\n");
		scanf("%s", familybus);
		


		printf("Code Melli:*\n");
		scanf("%d", &codebus);
		



		printf("Username:*\n");
		scanf("%s", usernamebus1);
		


		printf("Password:*\n");
		//scanf("%s", passwordbus1);
		while (1)
		{

			//scanf("%c", &ch);
			ch4 = getch();

			if (ch4 == 13)
			{
				passwordbus1[p] = '\0';
				break;
			}
			else if (ch4 == 8)
			{
				if (p > 0)
				{
					p--;
					printf("\b \b");
				}
			}
			else if (ch4 == 9 || ch4 == 32)
			{
				continue;
			}
			else
			{
				passwordbus1[p] = ch4;
				p++;
				printf("*");
			}
		}


		printf("\nConfirm Password:*\n");
		//scanf("%s", confpasswordbus1);
		while (1)
		{

			//scanf("%c", &ch);
			ch5 = getch();

			if (ch5 == 13)
			{
				confpasswordbus1[q] = '\0';
				break;
			}
			else if (ch5 == 8)
			{
				if (q > 0)
				{
					q--;
					printf("\b \b");
				}
			}
			else if (ch5 == 9 || ch5 == 32)
			{
				continue;
			}
			else
			{
				confpasswordbus1[q] = ch5;
				q++;
				printf("*");
			}
		}

		


		while (strcmp(passwordbus1, confpasswordbus1) != 0)
		{
			printf("\nError For Confirm Password:\n");
			//scanf("%s", confpasswordbus1);
			while (1)
			{

				//scanf("%c", &ch);
				ch6 = getch();

				if (ch6 == 13)
				{
					confpasswordbus1[r] = '\0';
					break;
				}
				else if (ch6 == 8)
				{
					if (r > 0)
					{
						r--;
						printf("\b \b");
					}
				}
				else if (ch6 == 9 || ch6 == 32)
				{
					continue;
				}
				else
				{
					confpasswordbus1[r] = ch6;
					r++;
					printf("*");
				}
			}


			continue;
		}

		printf("\nEmail Adress:*\n");
		scanf("%s", emailbus);
		


		printf("Shop Store Name:*\n");
		scanf("%s", store);
		


		printf("City:*\n");
		scanf("%s", city);
		



		printf("Reigon Of City:*\n");
		scanf("%d", &reigon);
		


		menu_bus();

		break;


	default:
		printf("\n\t\tWrong Choice\n\n");
		goto loop;
		break;
		
	}

}

///////////////////////      forget   /////////////////////////////////////////////////////

void forget()
{

	char email[30], userforg[30], newpassword[30], confnewpassword[30];
	int code;
	
	
	printf("Email Adress:\n");
	scanf("%s", email);


	printf("Username:\n");
	scanf("%s", userforg);

	printf("Code Melli:\n");
	scanf("%d", &code);

	if (strcmp(email, emailjob2) == 0 && strcmp(userforg, job2) == 0 && code == code_job2)
	{
		printf("New Password:\n");
		scanf("%s", newpassword);

		printf("Confirm New Password:\n");
		scanf("%s", confnewpassword);

		while (strcmp(newpassword, confnewpassword) != 0)
		{
			printf("Wrong confirm\n");
			scanf("%s", confnewpassword);
			continue;

		}
		strcpy(passjob2, confnewpassword);
		puts("ENTER YOUR MENU ?\n1.YES\n2.NO");
		int e;
		scanf("%d", &e);
		switch (e)
		{
		case 1:
			menu_bus();
			break;

		case 2:
			menu();
			break;

		default:
			puts("WRONG CHOICE");
			break;
		}

	}

	else if (strcmp(email,simuser[1].email) == 0 && strcmp(userforg,simuser[1].username) == 0 && code == simuser[1].codemelli)
	{
		printf("New Password:\n");
		scanf("%s", newpassword);

		printf("Confirm New Password:\n");
		scanf("%s", confnewpassword);

		while (strcmp(newpassword, confnewpassword) != 0)
		{
			printf("Wrong confirm\n");
			scanf("%s", confnewpassword);
			continue;

		}
		strcpy(simuser[1].password, confnewpassword);
		puts("ENTER YOUR MENU ?\n1.YES\n2.NO");
		int e;
		scanf("%d", &e);
		switch (e)
		{
		case 1:
			menu_simple();
			break;

		case 2:
			menu();
			break;

		default:
			puts("WRONG CHOICE");
			break;
		}
	}

	else
	{
		puts("\nTHIS INFO DOESNT REGISTER PREVIOUSLY\n");
		menu();
	}


}

///////////////////////      menu     /////////////////////////////////////////////////////

void menu()
{
	loop:puts("\t\t\t\t---------------------------------------------------------------");
	printf(ANSI_COLOR_YELLOW "\t\t\t\t|\t     \" W    E    L    C    O    M    E \"\t      |\n\n\t\t\t\t|\t\t     T  O      M  Y\t\t\t      |\n\n\t\t\t\t|\t         \" P  R  O  G  R  A  M  M \"\t\t      |\n" ANSI_COLOR_RESET);
	puts("\t\t\t\t---------------------------------------------------------------\n");
	puts("\n");
	printf(ANSI_COLOR_BLUE "%50s%52s%60s", "\t\t\t1.login\n\n", "\t\t\t2.sign up\n\n", "\t\t\t3.forget password\n\n" ANSI_COLOR_RESET);

	int choice;
	scanf("%d", &choice);

	switch (choice)
	{
	case 1:
		login();
		break;

	case 2:
		sign_up();
		break;

	case 3:
		forget();
		break;

	default:
		puts("\n\t\tWrong Choice\n");
		goto loop;

		break;
	}

}

//////////////////////       menu simple      ///////////////////////////////////////////////

void menu_simple()
{
	
	fp = fopen("simple_user.txt", "a+");
	char buffer[1000000];
	
	
	
	
	//struct simple_user men[100];
	//strcpy(simuser[user].csalamat, "0(empty)");
	loop:printf(ANSI_COLOR_GREEN "\n\t  ^_^   S  I  M  P  L  E       M  E  N  U   ^_^\n" ANSI_COLOR_RESET);
	printf(ANSI_COLOR_BLUE "\n\nYour Healthness Code is : %s \n"
		"1.experiment your healthness\n"
		"2.edit your info\n"
		"3.set the time to visit PEOPLE\n"
		"4.set the time to visit a PLACE\n"
		"5.times to last experiment healthness\n"
		"6.times to last 10time visit PEOPLE\n"
		"7.times to last 10time visit PLACE\n"
		"8.signout\n"
		"9.exit\n\n\n\n" 
		 ANSI_COLOR_RESET, simuser->csalamat[sdate]);

	char shomare[70];
	scanf("%s", shomare);
	int counter = 0;
	char y[10];
	//int count = 0;
	

	if (strcmp(shomare, "1") == 0 || strcmp(shomare, "experiment your healthness") == 0)
	{
		//o++;
		sdate++;
		printf("\n1.Sorfe khoshk ba tekrar\n");
		scanf("%s", y);
		if (strcmp(y, "yes") == 0)
			counter += 30;
		else
			counter += 0;

		printf("\n2.Tab bala 37 darage\n");
		scanf("%s", y);
		if (strcmp(y, "yes") == 0)
			counter += 20;
		else
			counter += 0;

		printf("\n3.Tangi nafas\n");
		scanf("%s", y);
		if (strcmp(y, "yes") == 0)
			counter += 20;
		else
			counter += 0;


		printf("\n4.Dard va koftegi\n");
		scanf("%s", y);
		if (strcmp(y, "yes") == 0)
			counter += 15;
		else
			counter += 0;


		printf("\n5.Gloo dard\n");
		scanf("%s", y);
		if (strcmp(y, "yes") == 0)
			counter += 15;
		else
			counter += 0;


		

		if (counter < 15 && counter >= 0) {
			strcpy(simuser->csalamat[sdate], "1(salem)");
			fprintf(fp, "%s\n", simuser->csalamat[sdate]);
			//strcpy(csalamat1, "1(salem)");
		}
		if (counter < 50 && counter >= 15) {
			strcpy(simuser->csalamat[sdate], "2(mashkook)");
			fprintf(fp, "%s\n", simuser->csalamat[sdate]);
			//strcpy(csalamat1, "2(mashkook)");
		}
		if (counter < 75 && counter >= 50) {
			strcpy(simuser->csalamat[sdate], "3(khatarnak)");
			fprintf(fp, "%s\n", simuser->csalamat[sdate]);
			//strcpy(csalamat1, "3(khatarnak)");
		}
		if (counter <= 100 && counter >= 75) {
			strcpy(simuser->csalamat[sdate], "4(bimar)");
			fprintf(fp, "%s\n", simuser->csalamat[sdate]);
			//strcpy(csalamat1, "4(bimar)");
		}

		/*health[u] = time(NULL);
		time(&health[u]);
		u++;*/
		simuser->salamat_date[time_counter] = time(NULL);
		time(&simuser->salamat_date[time_counter]);
		time_counter++;
		

		int b;
		printf("\nYour Helthness Situation Code is : %s\n", simuser->csalamat[sdate]);
		printf("\nDO YOU WANT TO RETURN YOUR MENU\n1.YES\n2.NO\n");
		scanf("%d", &b);

		if (b == 1) goto loop;//menu_simple();
		else
			menu();
		
	}
	
	//o++;

	if (strcmp(shomare, "2") == 0 || strcmp(shomare, "edit your info") == 0)
	{
		//fp = fopen("info_user.txt", "r+");
		printf("\n1.Name: --->%s\t\t2.Family Name: --->%s\t\t3.Username: --->%s\n", simuser->name, simuser->family, simuser->username);
		printf("\n4.Password: --->%s\t\t5.Blood: --->%s\t\t6.Email: --->%s\n", simuser->password, simuser->blood, simuser->email);
		printf("\n7.Code Melli: --->%d\t\t8.Age: --->%d\t\t9.Height: --->%d\n", simuser->codemelli, simuser->age, simuser->height);
		printf("\n10.Weight: --->%d\n", simuser->weight);
		printf("\n11.Return To Menu\n");
		int y;




		do
		{
			scanf("%d", &y);
			if (y == 1)
			{
				scanf("%s", simuser->name);
			}

			if (y == 2)
			{
				scanf("%s", simuser->family);
			}

			if (y == 3)
			{
				scanf("%s", simuser->username);
			}

			if (y == 4)
			{
				scanf("%s", simuser->password);
			}

			if (y == 5)
			{
				scanf("%s", simuser->blood);
			}

			if (y == 6)
			{
				scanf("%s", simuser->email);
			}

			if (y == 7)
			{
				scanf("%d", &simuser->codemelli);
			}

			if (y == 8)
			{
				scanf("%d", &simuser->age);
			}

			if (y == 9)
			{
				scanf("%d", &simuser->height);
			}

			if (y == 10)
			{
				scanf("%d", &simuser->weight);
			}

			if (y == 11)
			{
				menu_simple();
			}

			if (y > 11 || y < 1)
			{
				puts("\nWRONG CHOICE\n");

			}

		} while (y != 11);










	}

	if (strcmp(shomare, "3") == 0 || strcmp(shomare, "set the time to visit PEOPLE") == 0)
	{
		
		
		visit_people();
		
		
	}

	if (strcmp(shomare, "4") == 0 || strcmp(shomare, "set the time to visit a PLACE") == 0)
	{
		
		
		visit_place();
	}

	if (strcmp(shomare, "5") == 0 || strcmp(shomare, "times to last experiment healthness") == 0)
	{
		int y = 1, x = 1;
		tarikh_heathness(y,x);
	
	}

	if (strcmp(shomare, "6") == 0 || strcmp(shomare, "times to last 10time visit PEOPLE") == 0)
	{
		int y = 1, x = 0;
		tarikh_people(y,x);
	}

	if (strcmp(shomare, "7") == 0 || strcmp(shomare, "times to last 10time visit PLACE") == 0)
	{
		tarikh_place();
	}

	if (strcmp(shomare, "8") == 0 || strcmp(shomare, "signout") == 0)

	{
		//strcpy(csalamat[o], "0(empty)");
		menu();
	}

	if (strcmp(shomare, "9") == 0 || strcmp(shomare, "exit") == 0)
	{
		exit(0);
	}

	
	
}

//////////////////////       menu bus          /////////////////////////////////////////////

void menu_bus()
{
	printf(ANSI_COLOR_GREEN "\n\t ^_^   B  U  S  I  N  E  S  S        M  E  N  U    ^_^\n" ANSI_COLOR_RESET);
	printf(ANSI_COLOR_BLUE "\n\nYour Place Situation Is : %s\n1.register your shop store healthness\n2.edit info\n3.signout\n4.exit\n" ANSI_COLOR_RESET,vaz1);

	char adad[40];
	scanf("%s", adad);

	if (strcmp(adad, "1") == 0 || strcmp(adad, "register your shop store healthness") == 0)
	{
		/*char vaz1[10] = "RED";
		char vaz2[10] = "WHITE";*/
		char mnumber[30];

		printf("Your place is not safe(%s)\n", vaz1);
		printf("1.Disinfect my place\n");
		scanf("%s", mnumber);

		if (strcmp(mnumber, "1") == 0 || strcmp(mnumber, "Disinfect my place") == 0)
		{
			int a;
			printf("Your place is safe(%s)\n", strcpy(vaz1, vaz2));
			printf("DO YOU WANT TO RETURN YOR MENU\n1.YES\n2.NO\n");
			scanf("%d", &a);
			if (a == 1) menu_bus();
			else menu();

		}
	}

	if (strcmp(adad, "2") == 0 || strcmp(adad, "edit info") == 0)
	{
		editbus();
	}



	if (strcmp(adad, "3") == 0 || strcmp(adad, "signout") == 0)
	{
		strcpy(vaz1, "RED");
		menu();

	}

	if (strcmp(adad, "4") == 0 || strcmp(adad, "exit") == 0)
	{
		exit(0);
	}




}

//////////////////////       edit simple sign in    /////////////////////////////////////////

//void editsimple()
//
//{
//	//char namesimple_e[30], familysimple_e[30], usernamesimple1_e[30], passwordsimple1_e[30], emailsimple_e[30], blood_e[30];
//	//int codesimple_e, age_e, height_e, weight_e;
//	fp = fopen("info_user.txt", "r+");
//	printf("\n1.Name: --->%s\t\t2.Family Name: --->%s\t\t3.Username: --->%s\n", simuser->name,simuser->family ,simuser->username);
//	printf("\n4.Password: --->%s\t\t5.Blood: --->%s\t\t6.Email: --->%s\n", simuser->password, simuser->blood, simuser->email);
//	printf("\n7.Code Melli: --->%d\t\t8.Age: --->%d\t\t9.Height: --->%d\n", simuser->codemelli,simuser->age,simuser->height);
//	printf("\n10.Weight: --->%d\n",simuser->weight);
//	printf("\n11.Return To Menu\n");
//	int y;
//	
//
//	
//	
//	do
//	{
//		scanf("%d", &y);
//		if (y == 1)
//		{
//			scanf("%s", simuser->name);
//		}
//
//		if (y == 2)
//		{
//			scanf("%s", simuser->family);
//		}
//
//		if (y == 3)
//		{
//			scanf("%s", simuser->username);
//		}
//
//		if (y == 4)
//		{
//			scanf("%s", simuser->password);
//		}
//
//		if (y == 5)
//		{
//			scanf("%s",simuser->blood);
//		}
//
//		if (y == 6)
//		{
//			scanf("%s",simuser->email);
//		}
//
//		if (y == 7)
//		{
//			scanf("%d", &simuser->codemelli);
//		}
//
//		if (y == 8)
//		{
//			scanf("%d", &simuser->age);
//		}
//
//		if (y == 9)
//		{
//			scanf("%d", &simuser->height);
//		}
//
//		if (y == 10)
//		{
//			scanf("%d", &simuser->weight);
//		}
//
//		if (y == 11)
//		{
//			menu_simple();
//		}
//
//		if (y > 11 || y < 1)
//		{
//			puts("\nWRONG CHOICE\n");
//			
//		}
//
//	} while (y != 11);
//}

////////////////////////             edit  bus   sign in      ////////////////////////////////

void editbus()
{
	printf("\n\n1.%s\t\t\t2.%s\t\t\t3.%s\t\t\t4.%s\n\n5.%s\t\t\t6.%s\t\t\t7.%s\t\t\t8.%d\n\n9.%d\n\n\t\t\t\t\t\t10.RETURN MENU\n\n", namebus, familybus, usernamebus1, passwordbus1, emailbus, city, store, codebus, reigon);
	int n;
	scanf("%d", &n);

	if (n == 1)
	{
		scanf("%s", &namebus);
		editbus();
	}

	if (n == 2)
	{
		scanf("%s", &familybus);
		editbus();
	}

	if (n == 3)
	{
		scanf("%s", &usernamebus1);
		editbus();
	}

	if (n == 4)
	{
		scanf("%s", &passwordbus1);
		editbus();
	}

	if (n == 5)
	{
		scanf("%s", &emailbus);
		editbus();
	}

	if (n == 6)
	{
		scanf("%s", &city);
		editbus();
	}

	if (n == 7)
	{
		scanf("%s", &store);
		editbus();
	}

	if (n == 8)
	{
		scanf("%d", &codebus);
		editbus();
	}

	if (n == 9)
	{
		scanf("%d", &reigon);
		editbus();
	}

	if (n == 10)
	{
		menu_bus();
	}














}

////////////////////////          VISIT   PEOPLE         ////////////////////////////////////////

void visit_people()
{
	
	
	loop:printf("Enter NAME of people that you visit : \n\n");
	//scanf("%s", name_visit[cn_sign]);
	printf("Enter CODE MELLI people that you visit : \n\n");
    //scanf("%s", &codemeli_visit[cn_sign]);
	//z++;
	//cn_sign++;
	//vpeople_sign[cv_sign] = time(NULL);
	//time(&vpeople_sign[cv_sign]);
	//cv_sign++;
	

	printf("Do you want to continue ? \n\n1.Yes\n2.No\n\n");
	int e;
	scanf("%d", &e);
	if (e == 1) {
		//visit_people();
		goto loop;
	}
	else menu_simple();
	

}

/////////////////////////         TARIKHCHE     VISIT      PEOPLE           ///////////////////////////////////////

void tarikh_people(int y,int x)
{
	printf("YOU visit these people with these code in these times : \n\n\n");
	for (int i = 0; i < 10 ; i++)
	{
		
		//printf("%d-%s  -->  %s -->  %s \n\n",y,name_visit[x] , codemeli_visit[x],ctime(&vpeople_sign[i]));
		y++;
		x++;

	}
	printf("Do you want to return your menu ? \n\n1.Yes\n2.No\n\n");
	int e;
	scanf("%d", &e);
	if (e == 1) menu_simple();
	else {

		//cn_sign = 0;
		//cv_sign = 0;

		menu();

	}
}

////////////////////////             VISIT     PLACE          ///////////////////////////////////////////////

void visit_place()
{
	printf("Enter name of place : \n");
}

//////////////////////////        TARIKHCHE     VISIT    PLACE      ////////////////////////////////////

void tarikh_place()
{
	puts("hello\n");
}

///////////////////////////         TARIKHCHE    HEALTHNESS         /////////////////////////////////////

void tarikh_heathness(int y,int x)
{
	
	for (int i = 0; i <time_counter ; i++)
	{
	
		printf("%d-%s \t\t--> %s\n\n", y ,ctime(&simuser->salamat_date[i]),simuser->csalamat[i+1]);
		y++;
		//x++;
		
	}
	printf("Do you want to return your menu ? \n1.YES \n2.NO\n\n");
	int a;
	scanf("%d", &a);

	if (a == 1) {
		
		menu_simple();
		
	}
	else {
		/*strcpy(csalamat1, "0(empty)");
		x = 0;
		u = 0;
		o = 0;*/
		//health[u] = {};
		//strcpy(csalamat[o], "0(empty)");
		menu();

	}
	
}





/***************************************            main                    **************************************************/

int main()
{
	

	if(( fp = fopen("simple_user.txt", "r")))
	{
		fclose(fp);
	}
	else {
		//fp = fopen("info_user.txt", "a+");
		for (int i = 0; i < 2; i++) {
			fprintf(fp, "%s#%s#%s#%d#%s#%s#%s#%s#%s#%d#%d#%d\n", simuser[i].username, simuser[i].password, simuser[i].email,
				simuser[i].codemelli, simuser[i].csalamat, simuser[i].name, simuser[i].family,
				simuser[i].confirm_password, simuser[i].blood, simuser[i].age, simuser[i].height, simuser[i].weight);
		}
		fclose(fp);
	}
	menu();
	login();
	sign_up();
	forget();
	
	return 0;

}



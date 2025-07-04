/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2024 STMicroelectronics.
  * All rights reserved.
  *
  * This software is licensed under terms that can be found in the LICENSE file
  * in the root directory of this software component.
  * If no LICENSE file comes with this software, it is provided AS-IS.
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include <stdlib.h>
/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
void show(int number ){
		if(number == 5 ){
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);
			

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,1);
		
		HAL_Delay(5);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);		

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,1);

		HAL_Delay(5);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,1);

		HAL_Delay(5);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,1);

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,0);

		}
		else if(number == 6 ){
		
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);
			

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,0);
		
HAL_Delay(5);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);		

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,1);
HAL_Delay(5);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,1);
HAL_Delay(5);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,1);

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,0);		
		}
		else if(number == 7 ){
		
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);
			
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,0);
		HAL_Delay(5);

		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);		

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,1);
HAL_Delay(5);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,0);
HAL_Delay(5);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,1);

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,0);
HAL_Delay(5);
		
		}
		else if(number == 8 ){
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);
			

		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,0);
		HAL_Delay(5);

		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);		

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,1);
HAL_Delay(5);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,1);
HAL_Delay(5);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,1);

		

		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,0);
HAL_Delay(5);
		}
		else{
		
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);
			

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,0);
		HAL_Delay(10);

		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);		

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,1);
HAL_Delay(10);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,0);

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,1);
HAL_Delay(10);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_1,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_2,0);
		HAL_GPIO_WritePin(GPIOD,GPIO_PIN_3,1);

		
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_0,0);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_1,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_2,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_3,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_4,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_5,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_6,1);
		HAL_GPIO_WritePin(GPIOC,GPIO_PIN_7,0);

		HAL_Delay(10);}
}
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */

/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
 UART_HandleTypeDef huart1;

/* USER CODE BEGIN PV */

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_USART1_UART_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
uint8_t UART1_rxBuffer[12]={0};
UART_HandleTypeDef huart1;
/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_USART1_UART_Init();
  /* USER CODE BEGIN 2 */
	int input;
  /* USER CODE END 2 */


  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */
		HAL_UART_Receive(&huart1, UART1_rxBuffer, 12, 100);
		char* to_char = (char*)UART1_rxBuffer;
		input = atoi(to_char);
		show(input);
		HAL_UART_Transmit(&huart1, UART1_rxBuffer, 12, 100);
		HAL_Delay(10);
    /* USER CODE BEGIN 3 */
  }
  /* USER CODE END 3 */
}


/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Configure the main internal regulator output voltage
  */
  __HAL_RCC_PWR_CLK_ENABLE();
  __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE1);

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_NONE;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }

  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_HSE;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV1;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_0) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief USART1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_USART1_UART_Init(void)
{

  /* USER CODE BEGIN USART1_Init 0 */

  /* USER CODE END USART1_Init 0 */

  /* USER CODE BEGIN USART1_Init 1 */

  /* USER CODE END USART1_Init 1 */
  huart1.Instance = USART1;
  huart1.Init.BaudRate = 115200;
  huart1.Init.WordLength = UART_WORDLENGTH_8B;
  huart1.Init.StopBits = UART_STOPBITS_1;
  huart1.Init.Parity = UART_PARITY_NONE;
  huart1.Init.Mode = UART_MODE_TX_RX;
  huart1.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart1.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart1) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN USART1_Init 2 */

  /* USER CODE END USART1_Init 2 */

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{
  GPIO_InitTypeDef GPIO_InitStruct = {0};

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOH_CLK_ENABLE();
  __HAL_RCC_GPIOC_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOD_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOC, GPIO_PIN_0|GPIO_PIN_1|GPIO_PIN_2|GPIO_PIN_3
                          |GPIO_PIN_4|GPIO_PIN_5|GPIO_PIN_6|GPIO_PIN_7, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOD, GPIO_PIN_0|GPIO_PIN_1|GPIO_PIN_2|GPIO_PIN_3
                          |GPIO_PIN_4|GPIO_PIN_5|GPIO_PIN_6|GPIO_PIN_7, GPIO_PIN_RESET);

  /*Configure GPIO pins : PC0 PC1 PC2 PC3
                           PC4 PC5 PC6 PC7 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_1|GPIO_PIN_2|GPIO_PIN_3
                          |GPIO_PIN_4|GPIO_PIN_5|GPIO_PIN_6|GPIO_PIN_7;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOC, &GPIO_InitStruct);

  /*Configure GPIO pins : PD0 PD1 PD2 PD3
                           PD4 PD5 PD6 PD7 */
  GPIO_InitStruct.Pin = GPIO_PIN_0|GPIO_PIN_1|GPIO_PIN_2|GPIO_PIN_3
                          |GPIO_PIN_4|GPIO_PIN_5|GPIO_PIN_6|GPIO_PIN_7;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOD, &GPIO_InitStruct);

}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

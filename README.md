# 專案介紹

```
📦AI-Portfolio
 ┣ 📂機器學習
 ┃ ┣ 📜boston_regression(decision_tree).ipynb [波士頓房價迴歸分析--決策樹演算法]
 ┃ ┣ 📜cluster.ipynb [分群練習]
 ┃ ┣ 📜house_linear.ipynb [房價分析]
 ┃ ┣ 📜house_prices_advance_regression.ipynb [房價分析]
 ┃ ┣ 📜iris_classification(decision_tree).ipynb [鳶尾花分類--決策樹演算法]
 ┃ ┣ 📜news(新聞分類練習).ipynb [新聞分類--單純貝氏演算法]
 ┃ ┣ 📜poem(詩詞分類).ipynb [詩詞分類--單純貝氏演算法]
 ┃ ┣ 📜titanic.ipynb [鐵達尼號存活率預測--隨機森林演算法]
 ┃ ┣ 📜中文處理.ipynb [中文資料處理方法]
 ┃ ┗ 📜常態分布圖(左偏、右偏).ipynb [常態分佈圖；偏度調整]
 ┣ 📂深度學習
 ┃ ┣ 📜cnn.ipynb [cifar10分類--CNN分類]
 ┃ ┣ 📜fashion_mnist.ipynb [fashion_minst分類--單純MLP分類]
 ┃ ┣ 📜MLP.ipynb [minst分類--單純MLP分類]
 ┃ ┣ 📜sentiment(詞向量，情緒分析).ipynb [IMDB分類--詞向量]
 ┃ ┣ 📜transfer(遷移學習).ipynb [遷移學習]
 ┃ ┗ 📜人臉辨識.ipynb [face_recognition套件實作]
 ┣ 📂python基礎
 ┃ ┣ 📜tabelog爬蟲.ipynb
 ┃ ┗ 📜爬PPT表特版.ipynb
 ┣ 📂生活智慧王[.net與HTML]
 ┣ 📜LICENSE
 ┗ 📜README.md
```

---
# 學習Python的筆記
## 何謂資料科學

* 資料收集
```python=
Open Data (表格)
第三方服務API
爬蟲
```
* 資料分析
```python=
統計與機率（AI）
```

* 生成對抗網絡（英語：Generative Adversarial Network，簡稱GAN）

    是非監督式學習的一種方法，通過讓兩個神經網路相互博弈的方式進行學習。該方法由伊恩·古德費洛等人於2014年提出。 生成對抗網絡由一個生成網絡與一個判別網絡組成。生成網絡從潛在空間（latent space）中隨機取樣作為輸入，其輸出結果需要盡量模仿訓練集中的真實樣本。判別網絡的輸入則為真實樣本或生成網絡的輸出，其目的是將生成網絡的輸出從真實樣本中盡可能分辨出來。而生成網絡則要盡可能地欺騙判別網絡。兩個網絡相互對抗、不斷調整參數，最終目的是使判別網絡無法判斷生成網絡的輸出結果是否真實。
    生成對抗網絡常用於生成以假亂真的圖片。此外，該方法還被用於生成影片、三維物體模型等。
    雖然生成對抗網絡原先是為了無監督學習提出的，它也被證明對半監督學習、完全監督學習、強化學習是有用的。在一個2016年的研討會，楊立昆描述生成式對抗網絡是「機器學習這二十年來最酷的想法」。

* 最重要的是！學會與你的專精做結合

* Python的用途
```python=
架設網站與伺服器:django ,Flask
AI:pytouch等
爬蟲（暫時不做介紹）
表格:Pandas
GUI(圖形化介面)：tkinter ,PyQt
圖像分析：matplotlib ,seaborn ,plotly
遊戲等
```


## 運算元、運算子與變數說明與abs、pow實作

*  ### 程式世界的基本資料（重要！）
```python=
數字(1.2.3.4)
文字( "hi" )
其他(是否)
無: None
```
* ### 操縱方式（重要！）
```python=
功能
運算(+.-.*./.等)
左右的資料一定要同類型
#（數值不能與文字一起寫。其他程式語言可以，是因為他偷偷幫你做轉換再加起來執行）
```

* 符號

    在程式裡，"="沒有相等的意思，而是「給予名字」的意思。
    
* 數字

    在程式裡，內建小數會有誤差。
    ＃ Decimal可以解決此問題，但通常不會有人使用。只有在做計算機時才會使用。
    範例：
    ```python=
    a = 3 + 3.14
    print(a) #a = 6.140000000000001
    
    b = a * 2 
    print(b) #b = 12.2800000000000001 
    
    a = a * 3
    print(a) #a = 18.42
    
    abs 絕對值功能
    a = abs(-2 * a)
    print(a) #a = -36.84
    
    pow 次方的功能
    a = pow(a , 2)
    print(a) #a = 1357.1856000000002
    ```
     練習：
     BMI =（體重）/（身高）^ 2
     身高單位為公尺 ; 體重為公斤。
    ```python=
    BMI = 55 / pow(1.64 , 2)
    print(BMI) #BMI = 20.449137418203453
    ```
    
## 字串型態與len函數說明與實作

* 範例：
    ```python=
    a = "Hello"
    print(a) #a = Hello
    
    a = a + "Python" 
    print(a) #a = HelloPython
    
    同類型才可以運算
    a = a + "3"
    print(a) #a = HelloPython3
    
    len 長度有多長的功能
    print(len(a)) #a = 12
    
    # 如果要印成 長度：12，則可以這樣寫
    print("長度：", len(a)) #長度：12
    
    取其中一個文字
    假如取"HelloPython3"中的"P"
    則：
    print(a[5]) #a = P
    
    取最後一個文字
    假如取"HelloPython3"中的"3"
    則：
    print(a[len(a)-1]) #a = 3
    
    取其中一段的文字
    假如取"HelloPython3"中的"oPyt"
    則：
    print(a[4:8]) #a = oPyt
    # :後的數字不包含在內
    
    取其中一個文字到最後一個文字
    假如取"HelloPython3"中的"elloPython3"
    則：
    print(a[1:]) #a = elloPython3
    # :後不打數字會自動取到最後一個數字
    ```
* 重點：
     Python會給每個文字發號碼牌，用來計數。
    * EX：
         Python
         012345
     
     但要記得-1，即"號碼牌-1"
     
## 比較運算子與邏輯運算子的說明與實作

* 重點：
    布林值：是(Ture),否(False),and,or
    可產生『是、否』的有：
    ```python=
    數字： > , < , >= , <= , ==
    文字： == , in
    ```
    
* 範例：

    ```python=
    a = True
    print(a) #a = Ture
    
    a = 2 == 2 
    print(a) #a = True 
    
    print("apple" == "apple") # True
    
    print("apple" == "Apple") # False
    
    print("good" in "good morning") # True
    
    print("mon" in "good morning") # False
    # 因為他是檢查字串，要連續的文字才可以，並非單一文字
    
    or
    print("專門結合運算：",True or False) # 專門結合運算：True
    
    and
    print(5 > 3-1 and True) # True
    
    pow 次方的功能
    a = pow(a , 2)
    print(a) #a = 1357.1856000000002
    ```

## 條件判斷語法與input函數的說明與實作

* 關於「抉擇」的語法：
    如果天氣好我就出門，否則我就待在家裡。
    if 是否的判斷（布林運算），else 是否判斷為「否」則可執行此內容。
    " : " 與 " Tab "為一組，必須要縮排。
    
    
* 範例：
  判斷分數是否通過

    ```python=
    PASS:
    score = 87
    if score >= 60:
        print("PASS")
    else:
        print("FAIL")   
    # PASS
    
    FAIL:
    score = 57
    if score >= 60:
        print("PASS")
    else:
        print("FAIL")   
    # FAIL
    
    ```
    ## input與float之功能
  *   input:
      讀取使用者的輸入並回傳。
      此功能回傳的東西，一律被當成「文字」處理。
  *   float:
      把文字轉換成小數（數字）。
      
  *   範例：
  判斷分數是否通過

    ```python=
    score = input("請輸入成績") # 會被當成文字處理，因此輸入任何文字都可
    if score >= 60:
        print("PASS")
    else:
        print("FAIL")   
    
    
    score = float(input("請輸入成績")) # 此時若輸入「87.2」則可以得到PASS
    if score >= 60:
        print("PASS")
    else:
        print("FAIL")

    ```

## 巢狀條件判斷語法的說明與實作
   
* if、else、elif 之應用
* 範例：
  判斷分數是否通過及評比

    ```python=
    score = input("請輸入成績") 
    if score >= 60:
        print("PASS")
    else:
        print("FAIL")
        
    if score >= 90:
        print("Rank A")
    elif score >= 80:
        print("Rank B")
    elif score >= 70:
        print("Rank C")  
    else:
        print("Rank D")
        
    # 輸入99 則可以得出 "PASS" 和 "Rank A"
    ```
## 實作1: 猜拳遊戲
  * import 引述某篇文章
    random.的「.」為「的」的意思
    「,」同類型東西的分隔
    randint 隨機整數之功能

  * 電腦隨機出拳寫法(0、1、2)：
    ```python=
    me = int(input("請出拳 [0]剪刀 [1]石頭 [2]布")) 
    import random
    com = random.randint(0 , 2) # random的randint(最小值 , 最大值)
    print("你出的拳：", me)
    print("電腦出的拳：", com)
    
    # 假使你輸入"0" , 電腦有可能會隨機出"[0]剪刀 [1]石頭 [2]布"
    # 請出拳 [0]剪刀 [1]石頭 [2]布
    # 你出的拳：0
    # 電腦出的拳：2
    ```
    
  * 翻譯清單：
    0 "剪刀"
    1 "石頭"
    2 "布"
    
    list = ["剪刀" , "石頭" , "布"]
    
  * 電腦隨機出拳寫法(剪刀、石頭、布)：
    ```python=
    me = int(input("請出拳 [0]剪刀 [1]石頭 [2]布")) 
    import random
    com = random.randint(0 , 2) # random的randint(最小值 , 最大值)
    
    trans = ["剪刀" , "石頭" , "布"] # 清單名字：[號碼牌] 對應到0、1、2
    print("你出的拳：", trans[me]) #[]為查詢
    print("電腦出的拳：", trans[com]) #[]為查詢
    
    # 假使你輸入"0" , 電腦有可能會隨機出"[0]剪刀 [1]石頭 [2]布"
    # 請出拳 [0]剪刀 [1]石頭 [2]布
    # 你出的拳：剪刀
    # 電腦出的拳：布
    ```
    
  * 印出輸贏與平手：
    ```python=
    me = int(input("請出拳 [0]剪刀 [1]石頭 [2]布")) 
    import random
    com = random.randint(0 , 2) # random的randint(最小值 , 最大值)
    
    trans = ["剪刀" , "石頭" , "布"] # 清單名字：[號碼牌] 對應到0、1、2
    print("你出的拳：", trans[me])
    print("電腦出的拳：", trans[com])
    
    if me == com:
        print("平手")
    elif me == (com + 1) % 3:
        print("我贏了")
    else:
        print("我輸了")
        
    # 假使你輸入"0" , 電腦有可能會隨機出"[0]剪刀 [1]石頭 [2]布"
    # 請出拳 [0]剪刀 [1]石頭 [2]布 （輸入"0"）
    # 你出的拳：剪刀
    # 電腦出的拳：布
    # 我贏了
    ```
* ％（mod）：取「餘數」運算是一種把「值」限制住的運算
* 棒打老虎雞吃蟲：
    ```python=
    import random

    my = int(input("0.棒 1.虎 2.雞 3.蟲:"))
    com = random.randint(0, 3)
    l = ["棒", "虎", "雞", "蟲"]
    print("我:", l[my])
    print("電腦:", l[com])

    if my == (com - 1) % 4:
        print("WIN")
    elif com == (my - 1) % 4:
        print("LOSE")
    else:
        print("EVEN")
   
    ```


## 字串的專屬技能 - replace, upper
  * 專屬技能：
    1. 專屬資料 . 專屬功能
       * "."就是"的"的意思
       * 專屬功能：參數、回傳答案
       * google搜尋 "python string method" （method：方法的意思）
       * 找到"Python - Strings - Tutorialspoint"
       * 網址：https://www.tutorialspoint.com/python/python_strings.htm
       * 此網址的範例為python2的範例，只要看到 "print" 就自己加上()
       * 
       
    2.  replace() method 傳入的參數：
        #### Parameters
       * old − This is old substring to be replaced.
       * new − This is new substring, which would replace old substring.
       * max − If this optional argument max is given, only the first count     occurrences are replaced. 
       EX:帶入"3"則，最左邊3個被取代;帶入"5"則，最左邊5個被取代;都沒帶入東西，則"全部"被取代



* 專屬技能分為兩種：
  1. 不改。
     改舊的東西會回傳一個新的複製品且已改過的東西（所有字串的專屬技能都屬於此）
  2. 直接改。
     不會回傳新的東西

 * replace()之範例：
    ```python=
    a = "hellohellohello"
    b = a.replace("hello", "goodbye")
    print("不改舊的：", a)
    print("回傳新的：", b)
    
    # 不改舊的：hellohellohello
    # 回傳新的：goodbyegoodbyegoodbye
    
    
    a = a.replace("hello", "goodbye" , 2) 
    # "2"表示從左邊開始取代兩個"hello"，成為"goodbye"
    
    print(a)
    # goodbyegoodbyehello
    ```  
  * 作業：
    ```python=
    a = "hellohellohello"
    b = a.replace("hello", "goodbye")
    print("不改舊的：", a)
    print("回傳新的：", b)
    
    # 不改舊的：hellohellohello
    # 回傳新的：goodbyegoodbyegoodbye
    
    
    a = a.replace("hello", "goodbye" , 2) 
    # "2"表示從左邊開始取代兩個"hello"，成為"goodbye"
    
    print(a)
    # goodbyegoodbyehello
    
    # TODO：待辦事項
    # TODO：1)內容一樣，大小寫一樣。 
    # TODO：2)內容一樣，但大小寫不一樣。
    # TODO：3)內容不一樣。
    
    
    S1 = input("請輸入字串1")
    S2 = input("請輸入字串2")
    # 不改舊的：hellohellohello
    # 回傳新的：goodbyegoodbyegoodbye
    
    if S1 == S2:
        print("內容一樣，大小寫也一樣")
    elif S1.upper() == S2.upper()
        print("內容一樣，但大小寫不一樣")
    else:
        print("內容不一樣")
        
    # 請輸入字串1 hello
    # 請輸入字串2 Hello
    # 內容一樣，但大小寫不一樣
    ```  
  * 使用：
    1. lower()：沒有任何傳入參數就可以把全部的東西都轉成小寫。
    2. upper()：沒有任何傳入參數就可以把全部的東西都轉成大寫。
    3. islower()：如果有至少一個英文字母是小寫就會回傳"Ture"
    4. isupper()：如果有至少一個英文字母是大寫就會回傳"Ture"

## 跳脫字元
  * 逃脫字元包含以下：
      1. 換行："\n"
      2. Tab：\t
      3. Backspace(鼠標往前移一格，反空白)：\b
  * 算字數：len()

* 作業：
    ```python=
    a = "hello\nPython"
    print(a) 
    # hello
    # Python 
    
    print(len(a)) 
    # 12
    
    b = "hello\bPython"
    print(b) 
    # hellPython 
    
    print(b == hellPython) 
    # False  
    
    print(len(b)) 
    # 12  
    ```  
## 固定次數迴圈說明與實作
  * 迴圈：
    你寫一次，電腦幫你完成很多次。
    1. 初始條件：次數 = "0"
    2. 判斷條件：次數 ＜ "10"
    3. 更新條件：次數 + "1"

* 練習1：
    ```python=
    # 1. 初始
    times = 0
    
    # 2. 判斷
    while times < 10:
        print("hello")
        
    # 3. 更新
    times = times + 1
    
    # hello
    # hello
    # hello
    # hello
    # hello
    # hello
    # hello
    # hello
    # hello
    # hello
    
    ```   
* 練習2：
    ```python=
    # 1. 初始
    times = 0
    
    # 2. 判斷
    while times < 10:
        print(time + 1 ,"hello")
        
    # 3. 更新
    times = times + 1
    
    # 1 hello
    # 2 hello
    # 3 hello
    # 4 hello
    # 5 hello
    # 6 hello
    # 7 hello
    # 8 hello
    # 9 hello
    # 10 hello
    
    ```   
* 練習3：
    ```python=
    # 1. 初始
    times = 0
    
    # 2. 判斷
    while times < 10:
        print(2 * time + 1 ,"hello")
        
    # 3. 更新
    times = times + 1
    
    # 1 hello
    # 3 hello
    # 5 hello
    # 7 hello
    # 9 hello
    # 11 hello
    # 13 hello
    # 17 hello
    # 19 hello
    # 21 hello
    
    ```   
* 練習4：
    ```python=
    # 1. 初始
    times = 0
    
    # 2. 判斷
    while times < 10:
        print(10 - time ,"hello")
        
    # 3. 更新
    times = times + 1
    
    # 10 hello
    # 9 hello
    # 8 hello
    # 7 hello
    # 6 hello
    # 5 hello
    # 4 hello
    # 3 hello
    # 2 hello
    # 1 hello
    
    ```  
  ### "做什麼"跟"怎麼做，做幾次"是不同的。不要換寫法。
  
## 數值累加實作

* 練習:
    ```python=

    times = 0
    # 一個記憶區的概念
        result = 0 # result是"累加"的結果
    while times < 10:  
        result = result + (times +1)
        times = times + 1
    print("結果" ,result) 
    # 結果 55 (1+2+3+4+5+6+7+8+9+10=55)
    
    ```  
## 實作2:費式數列

斐波那契數列（義大利語：Successione di Fibonacci），又譯為菲波拿契數列、菲波那西數列、斐氏數列、黃金分割數列。

在數學上，費氏數列是以遞迴的方法來定義：
![](https://i.imgur.com/ijqrm14.png)

用文字來說，就是費氏數列由0和1開始，之後的斐波那契數就是由之前的兩數相加而得出。首幾個斐波那契數是：
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233……（OEIS中的數列A000045）

![](https://i.imgur.com/bteQ17D.png)

* 練習：
  ```python=
    # 除了第一項與第二項，其他 = 前2 + 前1
    lasttwo = 0
    lastone = 0 
    times = 0 # 此行絕對不變
    while times < 10: # 此行絕對不變
        if times == 0:
        lasttwo = 0
        ans = 0
        
        elif times == 1:
        lastone = 1
        ans = 1
        
        else:
        ans = lasttwo + lastone 
        lasttwo = lastone
        lastone = ans
        print("第" ,times + 1, "項：" , ans)
        times = times + 1 # 此行絕對不變
        
        # 第 1 項：0
        # 第 2 項：1
        # 第 3 項：1
        # 第 4 項：2
        # 第 5 項：3
        # 第 6 項：5
        # 第 7 項：8
        # 第 8 項：13
        # 第 9 項：21
        # 第 10 項：34
        
    ```  
## 不固定次數迴圈的說明與實作
* 練習:
    ```python=

    times = 0
    # 一個記憶區的概念
        result = 0 # result是"累加"的結果
        end = 50 #加到 > 50 才停，你最後加的數字是多少?
    
    while result <= end:  
        result = result + (times +1)
        times = times + 1
    
    print("最後加的是" ,times) 
    # 最後加的是 10
    
    
 ## 爬蟲_Google Doodle 的圖片
 * repl:
  https://repl.it/@AprilWuWu/1029#main.py

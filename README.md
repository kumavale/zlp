# Zerodori Listening Player
![stable](https://img.shields.io/badge/build-passing-success.svg)
![version](https://img.shields.io/badge/version-0.0.6-success.svg)
[![license](https://img.shields.io/badge/license-MIT-blue.svg?style=flat)](LICENSE)

[TOEIC(R)L&Rテスト リスニング ゼロからスコアが稼げるドリル](https://ec.alc.co.jp/book/7019027/)(通称:ゼロドリ) 付属の音声ファイル専用のmp3プレイヤー  
![ss](https://github.com/yorimoi/zlp/blob/master/resources/ss.png)  

## その他再生可能なもの(確認済)
* [TOEIC(R)L&Rテスト 英文法 ゼロからスコアが稼げるドリル](https://ec.alc.co.jp/book/7017060/)  
* [はじめて受けるTOEIC(R) L&Rテスト全パート完全攻略](https://ec.alc.co.jp/book/7018001/)  

※ 他本でもおそらく実行可能(未検証)

## Building
Building `zlp` with Visual Studio 2019  
For the full supported experience, you will need to have Visual Studio 2019 or higher.

To get started on Visual Studio 2019:

1. Install Visual Studio 2019. Select the following Workloads:  
* .NET desktop development  
2. Clone the source code (`git clone https://github.com/yorimoi/zlp.git` or Download ZIP).  
3. Open the file explorer. Navigate to project/solution directory  
4. Search for *.resx. => You will get list of resx files  
5. Right click the resx file, open the properties and check the option `'Unblock'`  
6. Repeat #5 for each resx file.  
7. Open `zerodori_listening_player.sln` in Visual Studio 2019.  
8. Find the dropdown box at the top of Visual Studio's window that says "Debug"  
9. Select "Release"  
10. Hit `Shift + Ctrl + B` to build it  

## Usage
書籍に記載されている方法でダウンロードした音声ファイルを`sounds`フォルダ配下に格納してください.  
`sounds/.ignore`フォルダ以下に格納したファイルは無視されます.  
#### 左上のテキストボックス
* 音声のトラック番号(音声ファイル名)の指定ができます  
* エンターキーで確定

#### speed
* 音声ファイルの再生スピードをドロップダウンから選択できます

#### volume
* スライダーでアプリ内音量を調整できます (左端でミュート)

#### each buttons
* `|<` (P)  
一つ前の音声ファイルへ
* `<` (←)  
5秒戻し<sup>※</sup>
* `▷`,`||` (␣)  
再生, 一時停止
* `>` (→)  
5秒送り<sup>※</sup>
* `>|` (N)  
一つ後の音声ファイルへ
* `↺` (L)  
ループの on/off
* `↳` (A)  
自動で次の音声を再生
* (Enter)  
初めから再生
* (↓, ↑)  
再生スピードのUp/Down

※ 秒数は変更可  

#### コンテキストメニュー(右クリック)
* 最前面  
On/Off
* キッチンタイマー  
* 各種設定  
巻き戻し/早送りの秒数  
透明度  
音声ファイルのパス  
ショートカットキー  


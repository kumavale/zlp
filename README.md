# Zerodori Listening Player
![stable](https://img.shields.io/badge/build-passing-success.svg)
![version](https://img.shields.io/badge/version-0.0.3-success.svg)
[![license](https://img.shields.io/badge/license-MIT-blue.svg?style=flat)](LICENSE)
  
[TOEIC(R)L&Rテスト リスニング ゼロからスコアが稼げるドリル](https://ec.alc.co.jp/book/7019027/)(通称:ゼロドリ) 付属の音声ファイル専用のmp3プレイヤー  
![ss](https://github.com/yorimoi/zlp/blob/master/resources/ss.png)  

## その他再生可能なもの(確認済)
* [はじめて受けるTOEIC(R) L&Rテスト全パート完全攻略](https://ec.alc.co.jp/book/7018001/)  

※ 他本でもおそらく実行可能(未検証)


## Usage
書籍に記載されている方法でダウンロードした音声ファイルを`sounds`フォルダ配下に格納してください.  
`sounds/.ignore`フォルダ以下に格納したファイルは無視されます.  
#### 左上のテキストボックス
* 音声のトラック番号の指定ができます  
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
* 各種設定  
巻き戻し/早送りの秒数  
透明度  
ショートカットキー  

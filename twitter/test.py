import tweepy
import re


Consumer_key = '8eFdAhBbLT0PPZPzUR83hnnrV'
Consumer_secret = 'qSaKMSZ6CTWbWk4Ix3vHrA0WesnLjFv5AOfndGPHzEorbjzS9B'
Access_token = '3016753953-VROJ8ZIJtyZ548nlTn1PM01ICJxyAHjxGCsqXri'
Access_secret = 'y3clVnfdkhiMFbhewLdkxneuCTp1HR2G76X3r93KgbETo'

# 認証
auth = tweepy.OAuthHandler(Consumer_key, Consumer_secret)
auth.set_access_token(Access_token, Access_secret)

api = tweepy.API(auth, wait_on_rate_limit=True)

# 検索キーワード設定
q = "はしれ！まえせつ"

# つぶやきを格納するリスト
tweets_data = []

# カーソルを使用してデータ取得
for tweet in tweepy.Cursor(api.search, q=q, count=100, tweet_mode='extended').items():
    tweet_text = tweet.full_text
    num = re.sub("\\D", "", tweet_text)
print(tweets_data)

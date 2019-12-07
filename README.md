# Redis.NetCore

What is Redis?
Redis stands for Remote Dictionary Server, and it is an open source in-memory key value data structure store. It supports data structures such as strings, hashes, list, set and more. Redis comes with different flavours like caching, session management, producer/consumer topic messaging and database.

Why do we use Redis?
Redis is speedy because everything stored in in-memory, so there is no hardware involved init. Redis was written in C language, that is why it is extremely fast.

Install Redis Server:
Step 1: Download the latest Redis zip file from the official git hub location. For me it is redis-2.4.5-win32-win64.zip.
Redis (Windows Download):
https://github.com/dmajkic/redis/downloads

Step 2: Extract redis-2.4.5-win32-win64.zip file in your preferred location.

Step 3: It will come with two different folders, one is for 32bit, and another one is 64bit based on your operating system.

Step 4: Goto 64bit there you can find below files.

Install Redis server on windows 10
Step 4: Double click on the redis-server.exe file, there you can see the redis-server startup and wait for connecting to clients like below.

Redis server on windows 10 2
Step 5: Now open the redis-cli.exe file to redis command line interface.

Install Redis server on windows 10 3
As this acts as a redis client, as soon as we open this cli, we can see the client connected message in redis server like below.

Install Redis server on windows 10 4
Now we can say that the redis server and client connected successfully. Now let’s try to pass some messages from the client to the redis server.

As we discussed redis is an in-memory key-value data structure store so that the data in redis represents as key-value pairs.

Inserting/Reading data into redis server:
Inserting data in redis:

Adding data into redis server
redis 127.0.0.1:6379> set "name" "Mohamed Salah"
OK

Reading data from redis:
redis 127.0.0.1:6379> get "name"
"Mohamed Salah"

This is th Redis Desktop Manager that will help you track your datasets:
https://redisdesktop.com/  and here is a quick start 
http://docs.redisdesktop.com/en/latest/quick-start/

How to run the application?

1. Download .Net Core 3.0 from https://dotnet.microsoft.com/download/dotnet-core/3.0
2. Clone the app.
3. Open it in visual studio.
4. Run Redis Server from cmd.exe > redis-server
5. Run the App and open this url: https://localhost:44368/Redis/
6. To store data into Redis db set open this url: https://localhost:44368/Redis/ShowMe?val=123456


response = openai.ChatCompletion.create(

    model="gpt-35-turbo",

    messages=[

        {"role": "system", "content": "You are a helpful assistant."},

        {"role": "user", "content": "That was an awesome experience"},

        {"role": "assistant", "content": "positive"},

        {"role": "user", "content": "I won't do that again"},

        {"role": "assistant", "content": "negative"},

        {"role": "user", "content": "That was not worth my time"},

        {"role": "assistant", "content": "negative"},

        {"role": "user", "content": "You can't miss this"}

    ]

)

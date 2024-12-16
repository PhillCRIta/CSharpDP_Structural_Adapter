### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Adapter pattern
This pattern Adapt the class to a different form.
In our case the folder ExternalPackage rapresent a package that is not possibile edit directly. Inside that folder there is an our Rainbow class that is wrapped inside a RainbowColorAdapter class for extend and/or adapt the functionality of original Rainbow class.
SpriteCreator
=============

Image Sprites are a very good way to feed your application some images. Basically, it consists of combining a set of images in a larger one and then just caching it. When you need one of the small images, all you have to know are the coordinates of it on the large one. With this technique, you just need to load one image for the entire application and reuse it, instead of loading each image at a time.
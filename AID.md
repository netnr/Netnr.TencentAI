# ����
> ͼƬ����ת������ȡҳ�����ʵ�

### ����ʱ��
2019-03-15

### ͼƬbase64����ת�����߹���
<https://ss.netnr.com/imagetobase64>

### ��ȡ�ֵ�
- ͼƬʶ��>����ʶ�������ʶ���壩<https://ai.qq.com/doc/vision_object.shtml>
- ͼƬʶ��>����ʶ�𣨳�����ʶ���壩<https://ai.qq.com/doc/vision_scene.shtml>

```
var kvs = [], arr = [];
$('table').last().find('td').each(function () {
    kvs.push(this.innerHTML)
})
for (var i = 0; i < kvs.length; i++) {
    arr[kvs[i]] = kvs[++i]
}
console.log(arr.join(','))
```

- <https://ai.qq.com/doc/ptuimgfilter.shtml>
- ͼƬ��Ч>ͼƬ�˾�������Pͼ����Ԥ���˾�Ч�����룩

```
var kvs = [], arr = [];
$('table').eq(6).find('td').each(function () {
    kvs.push(this.innerHTML)
})
for (var i = 0; i < kvs.length; i++) {
    var obj = {};
    obj.id = kvs[i];
    obj.name = kvs[++i];
    if (obj.id != "") {
        var img = kvs[++i];
        img.replace(/\/.*?"/g, function (x) {
            obj.image_url = x.substr(0, x.length - 1)
        })
        arr.push(obj);
    }
}
console.log(JSON.stringify(arr))
```

- <https://ai.qq.com/doc/ptuimgfilter.shtml>
- ͼƬ��Ч>ͼƬ�˾���AI Lab����Ԥ���˾�Ч�����룩

```
var kvs = [], arr = [];
$('table').last().find('td').each(function () {
    kvs.push(this.innerHTML)
})
for (var i = 0; i < kvs.length; i++) {
    var img = kvs[i + 1];
    img.replace(/\/.*?"/g, function (x) {
        arr[kvs[i]] = x.substr(0, x.length - 1);
    })
    i++;
}
console.log(arr.join(','))
```
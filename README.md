# CS.Batch.Renaming #
两步走，批量修改文件名称。

# 思路 #

首先建立一个文本文件，文件名称任意。

这个文件的第一行是未来新文件名称的开始部分。

该文件可以包含多行数据，主要是原有文件名称内部的文字的替换规则。

比如：

	大汤-凌声		;	Thompson-

第一步

	[make old name and new name]	

选取上面的文本文件，将得到一个文件。

	file-new-name-listing.txt

第二步

	[change file name using rule file]

事先，可以修改 file-new-name-listing.txt , 对其中的不能批量改变的内容进行手工修改。

比如，一批文件的序列号。
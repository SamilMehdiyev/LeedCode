package solutions

// MyHashSet - custom HashSet component
// from leetcode.com
type MyHashSet struct {
	data [][]int
}

// Constructor - is a Initialize
func Constructor() MyHashSet {
	data := make([][]int, 255)
	return MyHashSet{data}
}

// Add - is a function for adding a new element into HashSet component
func (this *MyHashSet) Add(key int) {
	if !this.Contains(key) {
		bucket := this.data[key%255]
		bucket = append(bucket, key)
		this.data[key%255] = bucket
	}
}

// Remove - is a function for removing an element into HashSet component
func (this *MyHashSet) Remove(key int) {
	if this.Contains(key) {
		bucket := this.data[key%255]

		for i := 0; i < len(bucket); i++ {
			if bucket[i] == key {
				bucket[i] = 0
			}
		}
	}
}

// Contains - is a function for checking an element exist or not in HashSet component
func (this *MyHashSet) Contains(key int) bool {
	bucket := this.data[key%255]

	for i := 0; i < len(bucket); i++ {
		if bucket[i] == key {
			return true
		}
	}

	return false
}

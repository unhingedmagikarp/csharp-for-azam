import unittest
from bubble import bubble, advanced_bubble


class Bubble(unittest.TestCase):

    def test_bubble(self):
        self.assertEqual([5, 9, 12, 24, 34], bubble([43, 12, 24, 9, 5]))

    def test_advanced_bubble(self):
        self.assertEqual([34, 24, 12, 9, 5], advanced_bubble([43, 12, 24, 9, 5], True))

if __name__ == '__main__':
    unittest.main()
